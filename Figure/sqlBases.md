## Script SQL : Cr�ation des tables **Personne** et **Chien**

Voici le script SQL pour cr�er les tables **Personne** et **Chien**, avec une relation `One-to-Many` (un chien peut avoir un ma�tre, mais ce n'est pas obligatoire) :

```sql
-- Table for people
CREATE TABLE People (
   id INT PRIMARY KEY IDENTITY(1,1), -- Unique ID for each person
   first_name NVARCHAR(50) NOT NULL, -- First name of the person
   last_name NVARCHAR(50) NOT NULL, -- Last name of the person
   age INT, -- Age of the person
   phone_number NVARCHAR(20), -- Phone number of the person
   address NVARCHAR(100), -- Address of the person
);

-- Table for dogs
CREATE TABLE Dogs (
   id INT PRIMARY KEY IDENTITY(1,1), -- Unique ID for each dog
   name NVARCHAR(50) NOT NULL, -- Name of the dog
   breed NVARCHAR(50), -- Breed of the dog
   age INT, -- Age of the dog
   size DECIMAL(5,2), -- Size (in cm) of the dog
   weight DECIMAL(5,2), -- Weight (in kg) of the dog
   owner_id INT, -- Foreign key referencing Person
   FOREIGN KEY (owner_id) REFERENCES People(id)
);
```

---

## Donn�es initiales pour les tables **Personne** et **Chien**

Voici un jeu de donn�es r�aliste et vari� pour d�montrer les jointures.

```sql
INSERT INTO People (first_name, last_name, age, phone_number, address)
VALUES 
   ('Tintin', 'Dupont', 30, '1234567890', '123 Rue du Temple'),
   ('Asterix', 'Gaulois', 40, '9876543210', '456 Village Gaulois'),
   ('Sherlock', 'Holmes', 45, '5554443333', '123 Main St'),
   ('Hercule', 'Poirot', 50, '4443332222', '11 Rue du Luxembourg'),
   ('Gandalf', 'Le Gris', 1000, '1112223333', 'Hobbiton'),
   ('Luke', 'Skywalker', 28, '9988776655', 'Tatooine'),
   ('Harry', 'Potter', 35, '5556667777', '4 Privet Drive'),
   ('Daenerys', 'Targaryen', 32, '8887776666', 'Meereen'),
   ('Frodo', 'Baggins', 33, '1237894560', 'Bag End'),
   ('Waldo', 'Rosenbaum', 50, '7778889999', 'Nowhere Street');

INSERT INTO Dogs (name, breed, age, size, weight, owner_id)
VALUES 
   ('Milou', 'Fox Terrier', 5, 30.0, 8.0, 1),
   ('Idefix', 'Dogmatix', 4, 25.0, 6.0, 2), 
   ('Watson', 'Bulldog', 6, 60.0, 30.0, 3), 
   ('Hercules', 'Pitbull', 3, 60.0, 28.0, 4), 
   ('Gandalf', 'Great Dane', 8, 80.0, 50.0, 5),
   ('Chewie', 'Malamute', 7, 70.0, 40.0, 6), 
   ('Buck', 'Saint Bernard', 6, 70.0, 50.0, 7),
   ('Drogo', 'Dobermann', 5, 55.0, 35.0, 8), 
   ('Baggins', 'Shiba Inu', 4, 30.0, 10.0, NULL),
   ('Waldo', 'Chihuahua', 3, 20.0, 2.5, 10), 
   ('Rex', 'Chihuahua', 3, 20.0, 3.0, NULL), 
   ('Pepette', 'Rottweiler', 6, 60.0, 40.0, 5), 
   ('Princesse', 'Dobermann', 4, 50.0, 30.0, 5), 
   ('Rex', 'Dalmatian', 2, 45.0, 25.0, 5), 
   ('Trixie', 'Poodle', 5, 30.0, 12.0, 5), 
   ('Nina', 'Boxer', 4, 50.0, 35.0, NULL), 
   ('Pikachu', 'Corgi', 2, 25.0, 10.0, 8), 
   ('Rolo', 'Dachshund', 3, 28.0, 8.5, NULL), 
   ('Fifi', 'Maltese', 4, 25.0, 6.0, NULL), 
   ('Charlie', 'Beagle', 6, 40.0, 15.0, NULL), 
   ('Max', 'Labrador', 5, 55.0, 30.0, NULL), 
   ('Biscuit', 'Shih Tzu', 2, 25.0, 6.0, 8),
   ('Daisy', 'Pug', 3, 35.0, 10.0, NULL), 
   ('Oscar', 'Terrier', 4, 28.0, 8.0, NULL), 
   ('Nala', 'Pitbull', 4, 50.0, 30.0, NULL); 

```

---

## Questions

### Niveau 1 : Questions basiques
1. S�lectionnez tous les chiens avec leur nom, leur race et leur poids.

SELECT name, breed, weight
FROM Dogs;

2. Listez tous les propri�taires (pr�nom et nom).

 SELECT first_name, last_name
 FROM People;

3. R�cup�rez les chiens qui n'ont pas de ma�tre.

 SELECT *
 FROM Dogs
 WHERE owner_id IS NULL;

4. S�lectionnez tous les chiens de race "Labrador".

 SELECT *
 FROM Dogs
 WHERE breed = 'Labrador';

### Niveau 2 : Jointures simples (INNER JOIN)
5. Affichez le nom des chiens avec le pr�nom et le nom de leur ma�tre.

 SELECT Dogs.name AS DogName, People.first_name AS OwnerFirstName, People.last_name AS OwnerLastName
 FROM Dogs
 INNER JOIN People ON Dogs.owner_id = People.id;

6. R�cup�rez les ma�tres qui poss�dent un chien pesant plus de 20 kg.

 SELECT People.first_name, People.last_name
 FROM People
 INNER JOIN Dogs ON People.id = Dogs.owner_id
 WHERE Dogs.weight > 20;

### Niveau 3 : LEFT JOIN
7. Affichez tous les propri�taires et les chiens qu'ils poss�dent, y compris les propri�taires sans chien.

 SELECT People.first_name, People.last_name, Dogs.name AS DogName
 FROM People
 LEFT JOIN Dogs ON People.id = Dogs.owner_id;

8. Listez tous les chiens, avec leurs ma�tres s'ils en ont, sinon affichez "No Owner".

 SELECT Dogs.name AS DogName, 
		COALESCE(People.first_name + ' ' + People.last_name, 'No Owner') AS OwnerName
 FROM Dogs
 LEFT JOIN People ON Dogs.owner_id = People.id;

### Niveau 4 : FULL OUTER JOIN
9. R�cup�rez tous les chiens et tous les ma�tres, m�me ceux sans correspondance.

 SELECT People.first_name AS OwnerFirstName, People.last_name AS OwnerLastName, Dogs.name AS DogName
 FROM People
 FULL OUTER JOIN Dogs ON People.id = Dogs.owner_id;

### Niveau 5 : Filtrage avanc�
10. Affichez les chiens dont le poids est sup�rieur � 10 kg mais inf�rieur � 30 kg.
	
 SELECT *
 FROM Dogs
 WHERE weight > 10 AND weight < 30;
	
11. R�cup�rez les chiens de ma�tres habitant dans la ville "123 Main St".
	
 SELECT Dogs.name AS DogName, People.first_name AS OwnerFirstName, People.last_name AS OwnerLastName
 FROM Dogs
 INNER JOIN People ON Dogs.owner_id = People.id
 WHERE People.address = '123 Main St';

### Niveau 6 : Agr�gats et GROUP BY
12. Affichez le nombre de chiens pour chaque ma�tre.

 SELECT People.first_name, People.last_name, COUNT(Dogs.id) AS NumberOfDogs
 FROM People
 LEFT JOIN Dogs ON People.id = Dogs.owner_id
 GROUP BY People.first_name, People.last_name;

13. Calculez le poids total des chiens appartenant � chaque ma�tre.

 SELECT People.first_name, People.last_name, SUM(Dogs.weight) AS TotalDogWeight
 FROM People
 LEFT JOIN Dogs ON People.id = Dogs.owner_id
 GROUP BY People.first_name, People.last_name;

### Niveau 7 : Sous-requ�tes
14. R�cup�rez les ma�tres qui poss�dent le chien le plus lourd.

 SELECT People.first_name, People.last_name
 FROM People
 WHERE People.id IN (
	 SELECT Dogs.owner_id
	 FROM Dogs
	 WHERE Dogs.weight = (SELECT MAX(weight) FROM Dogs)
 );

15. Affichez les chiens qui ont un ma�tre dont l'�ge est sup�rieur � 40 ans.

 SELECT Dogs.name AS DogName, People.first_name AS OwnerFirstName, People.last_name AS OwnerLastName
 FROM Dogs
 INNER JOIN People ON Dogs.owner_id = People.id
 WHERE People.age > 40;

### Niveau 8 : Cas complexes
16. Listez les ma�tres n'ayant pas de chien.

 SELECT People.first_name, People.last_name
 FROM People
 LEFT JOIN Dogs ON People.id = Dogs.owner_id
 WHERE Dogs.id IS NULL;

17. Affichez la race la plus courante parmi les chiens.

 SELECT breed, COUNT(*) AS BreedCount
 FROM Dogs
 GROUP BY breed
 ORDER BY BreedCount DESC
 OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY;

18. Listez tous les ma�tres qui poss�dent au moins deux chiens.

 SELECT People.first_name, People.last_name
 FROM People
 INNER JOIN Dogs ON People.id = Dogs.owner_id
 GROUP BY People.first_name, People.last_name
 HAVING COUNT(Dogs.id) >= 2;

### Niveau 9 : FULL OUTER JOIN combin�
19. R�cup�rez une liste combin�e de chiens sans ma�tres et de ma�tres sans chiens.
	
 SELECT People.first_name AS OwnerFirstName, People.last_name AS OwnerLastName, Dogs.name AS DogName
 FROM People
 FULL OUTER JOIN Dogs ON People.id = Dogs.owner_id
 WHERE People.id IS NULL OR Dogs.id IS NULL;

20. Affichez le ma�tre et ses chien associ�s avec somme de leur tailles respectives (taille du ma�tre et des chiens).

 SELECT People.first_name AS OwnerFirstName, People.last_name AS OwnerLastName, 
		SUM(Dogs.size) AS TotalDogSize
 FROM People
 LEFT JOIN Dogs ON People.id = Dogs.owner_id
 GROUP BY People.first_name, People.last_name;

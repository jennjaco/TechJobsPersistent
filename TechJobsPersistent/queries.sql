--Part 1
SELECT * FROM Jobs;
DESCRIBE Jobs;

--Part 2
SELECT * FROM Employers WHERE location = "St. Louis";

--Part 3
SELECT Name, Description FROM Skills
INNER JOIN JobSkills ON JobSkills.SkillId = Skills.Id;
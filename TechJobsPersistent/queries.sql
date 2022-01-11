--Part 1
<--Employers-->
employers.Id int
employers.Name longtext
employers.Location longtext

<--Jobs-->
jobs.Id int,
jobs.Name longtext,
jobs.EmployerId int

<--JobSkills-->
jobskills.JobId int
jobskills.SkillId int

<--Skills-->
skills.Id int
skills.Name longtext
skills.Description longtext


--Part 2
<--query to list the names of the employers in St. Louis City-->

SELECT Name FROM Employers WHERE Location = "St. Louis City";

--Part 3

<--write a query to return a list of the names and descriptions of all skills that 
<--are attached to jobs in alphabetical order. If a skill does not have a job listed,
<--it should not be included in the results of this query.-->

SELECT * FROM skills 
    LEFT JOIN skills ON skills.Id = jobskills.SkillId
    WHERE jobSkills.JobId IS NOT NULL
    ORDER BY name ASC;
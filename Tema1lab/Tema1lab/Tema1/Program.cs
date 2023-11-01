using Tema1lab.Tema1;

Materie materie1 = new Materie("OOP", 2, 2);
Materie materie2 = new Materie("Algebra", 3, 1);
Materie materie3 = new Materie("Analiza", 1, 3);

List<Student> studenti = new List<Student>();

Student student1 = new Student("Asan", "Alexandru", 20);
student1.adaugaMaterie(materie2);
student1.adaugaMaterie(materie3);
studenti.Add(student1);

Student student2 = new Student("Ionascu", "Dragos", 20);
student2.adaugaMaterie(materie1);
student2.adaugaMaterie(materie2);
studenti.Add(student2);

Student student3 = new Student("Rosu", "Eric", 21);
student3.adaugaMaterie(materie1);
student3.adaugaMaterie(materie2);
student3.adaugaMaterie(materie3);
studenti.Add(student3);

foreach (Student student in studenti)
{
    student.afiseazaDetalii();
}
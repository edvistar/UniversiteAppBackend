namespace UniversiteAppBackend.Models.DataModels
{
    public class Services
    {
        static public void SearchUsuariosEmail()
        {
            var users = new[]
            {
                new User()
                {
                    Id = 1,
                    Name = "Maria",
                    LastName = "Castro",
                    Email = "maria@gmail.com"
                },
                 new User()
                {
                     Id = 2,
                    Name = "Jose",
                    LastName = "Restrepo",
                    Email = "jose@gmail.com"
                },
                  new User()
                {
                      Id = 3,
                    Name = "Pedro",
                    LastName = "Jmenez",
                    Email = "pedro@gmail.com"
                }
            };
            var userList = users.SelectMany(user => user.Email);
        }
        static public void AlumnosMayoresDeEdad()
        {
            var students = new[]
            {
                new Student()
                {
                    Id = 1,
                    FirstName = "Isabel",
                    LastName  = "Sandoval",
                    Age = 18,
                    Courses = new[]
                    {
                        new Course()
                        {
                            Id=1,
                            Name = "C#",
                            ShortDescription = "Inicial"
                        },
                        new Course()
                        {
                            Id = 2,
                            Name = "C# Avanzado",
                            ShortDescription = "Avanzado"
                        },
                        new Course()
                        {
                            Id=3,
                            Name = "Angular",
                            ShortDescription = "Basico"
                        },
                    }

                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Rocio",
                    LastName  = "Palacios",
                    Age = 15,
                    Courses = new[]
                    {
                        new Course()
                        {
                            Id=1,
                            Name = "C#",
                            ShortDescription = "Inicial"
                        },
                        new Course()
                        {
                            Id = 2,
                            Name = "C# Avanzado",
                            ShortDescription = "Avanzado"
                        },
                        new Course()
                        {
                            Id=3,
                            Name = "Angular",
                            ShortDescription = "Basico"
                        },
                    }

                }
            };
            var studentsMayores = students.Any(edad => edad.Age > 18);   
            var stundentCurso = students.Any(s => s.Courses.Count > 0); 
        }

        static public void CursosStudiantes()
        {
            var cursos = new[]
            {
                new Course()
                {
                    Id=1,
                    Name = "Angular",
                    Level = Level.Basic,
                    Categories = new[]
                    {
                        new Category()
                        {
                            Id=1,
                            Name = "Frontend"
                        }
                    },
                    Students = new []
                    {
                        new Student()
                        {
                            Id=1,
                        }
                    }

                },
                new Course()
                {
                    Id=2,
                    Name = "dotNet",
                    Level = Level.Basic,
                    Categories = new[]
                    {
                        new Category()
                        {
                            Id=2,
                            Name = "Backend"
                        }
                       
                    },
                    Students = new []
                    {
                        new Student()
                        {
                            Id=2,
                        }
                    }

                }
            };

            var cursosStudent = cursos.Any(cu=> cu.Students.Count > 0);
            var cursoNivel = cursos.Any(cu => cu.Students.Count > 0 && cu.Level == Level.Basic);
            var cursoCategoria = cursos.Any(ca => ca.Level == Level.Basic && ca.Categories.Any(ni=> ni.Name == "Backend"));
            var cursoSinAlumno = cursos.Any(al => al.Students.Count == 0);
            
        }
    }
}


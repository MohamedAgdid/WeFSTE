using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WeFSTE.Models;

namespace WeFSTE.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {


        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                  new Category { Id = 1, Name = "Projets Académiques" },
                  new Category { Id = 2, Name = "Articles Scientifiques" },
                  new Category { Id = 3, Name = "Tutoriels et Cours" },
                  new Category { Id = 4, Name = "Événements et Ateliers" },
                  new Category { Id = 5, Name = "Stages et Opportunités" },
                  new Category { Id = 6, Name = "Vie Étudiante" },
                  new Category { Id = 7, Name = "Compétitions & Hackathons" },
                  new Category { Id = 8, Name = "Retour d’Expérience" }
            );
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "Obstacle-Avoiding Mobile Robot with Arduino",
                    Content = "<p>\r\n    In this project, we build a mobile autonomous robot capable of detecting and avoiding obstacles. \r\n    The robot moves forward in a straight line and, when an obstacle is detected, it stops and rotates \r\n    to change direction. This is achieved using an HC-SR04 ultrasonic distance sensor, making the project \r\n    a great introduction to embedded robotics using Arduino UNO.\r\n  </p>\r\n\r\n  <h3>Components Used</h3>\r\n  <ul>\r\n    <li>Arduino UNO board</li>\r\n    <li>L298N motor driver module</li>\r\n    <li>HC-SR04 ultrasonic sensor with holder</li>\r\n    <li>2 TT gear motors + wheels + universal caster wheel</li>\r\n    <li>2WD robot chassis</li>\r\n    <li>Battery holder (4×AA) + 9V battery</li>\r\n    <li>ON/OFF switch, jumper wires, screws, nuts</li>\r\n    <li>Mini breadboard</li>\r\n    <li>LEDs for visual indicators</li>\r\n  </ul>",
                    Author = "Arduino Tech",
                    PublishedDate = new DateTime(2025, 2, 11),
                    CategoryId = 1,
                    FeatureImagePath = "/images/robot.jpg",
                    IdUser = "Null" 
                },
                new Post
                {
                    Id = 2,
                    Title = "Huawei’s AI Ascent",
                    Content = "<h2>The Ascend AI Chip Series: China’s Answer to NVIDIA</h2>" +
                    "<p>Ascend 920C: Huawei’s flagship AI GPU combines two 910B processors into a single package, delivering performance comparable to NVIDIA’s H100. Mass shipments began in May 2025, positioning it as China’s primary alternative after U.S. blocked NVIDIA’s H20 sales." +
                    "</p><p>Production Challenges: U.S. officials cap Huawei’s 2025 output at 200,000 chips—far below NVIDIA’s 1 million+ H20 GPUs shipped in late 2024. Yet, Commerce Under Secretary Jeffrey Kessler warns against complacency: \"China is catching up quickly\" </p>" +
                    "<p>Architectural Innovation: The 920C uses advanced integration techniques rather than process-node breakthroughs, reflecting Huawei’s pragmatic approach amid semiconductor restrictions</p>",
                    Author = "Huawei inc",
                    PublishedDate = new DateTime(2025, 1, 15),
                    CategoryId = 2,
                    FeatureImagePath = "/images/Huawei.jpeg",
                    IdUser = "Null"
                },
                new Post
                {
                    Id = 3,
                    Title = "Full-Stack Developer 2025",
                    Content = "<p>\r\n    In this tutorial, we guide you through the essential skills and tools required to become a Full-Stack Developer in 2025. \r\n    With the rapid evolution of web technologies, developers must master both frontend and backend development, \r\n    deploy secure applications, and stay current with best practices.\r\n  </p>\r\n\r\n  <h3>What You’ll Learn</h3>\r\n  <ul>\r\n    <li><strong>Frontend:</strong> HTML5, CSS3, JavaScript (ES6+), TypeScript, React.js, and modern UI frameworks like Tailwind CSS.</li>\r\n    <li><strong>Backend:</strong> Node.js or ASP.NET Core, RESTful APIs, authentication, and role management.</li>\r\n    <li><strong>Databases:</strong> SQL (PostgreSQL / MySQL) and NoSQL (MongoDB).</li>\r\n    <li><strong>DevOps:</strong> Docker, GitHub Actions, and deployment to platforms like Vercel or Azure.</li>\r\n    <li><strong>Best Practices:</strong> Clean Code, MVC pattern, unit testing, and CI/CD.</li>\r\n  </ul>",
                    Author = "Mohamed Agdid",
                    PublishedDate = new DateTime(2025, 6, 20),
                    CategoryId = 3,
                    FeatureImagePath = "/images/Tutoriels.png",
                    IdUser = "Null"
                },

                new Post
                {
                    Id = 5,
                    Title = "Huawei ICT Competition",
                    Content = " <p>\r\n    The Huawei ICT Competition 2025 is a global technology challenge for university students. \r\n    It focuses on skills in networking, cloud computing, AI, and cybersecurity. \r\n    Students from over 70 countries, including Morocco, take part each year.\r\n  </p>\r\n  <p>\r\n    Participants solve real-world problems using Huawei technologies. \r\n    Top performers receive certificates, internships, and international recognition. \r\n    The competition strengthens ties between universities and the tech industry.\r\n  </p>\r\n  <p>\r\n    The 2025 edition highlights green ICT and intelligent connectivity. \r\n    It includes online exams, hands-on labs, and national qualifiers. \r\n    The program prepares students for careers in the ICT sector. \r\n    Huawei continues to support digital talent through innovation and education.\r\n  </p>",
                    Author = "Mohamed Agdid",
                    PublishedDate = new DateTime(2025, 6, 20),
                    CategoryId = 7,
                    FeatureImagePath = "/images/ict.jpg",
                    IdUser = "Null"
                }

                ,
                 new Post
                {
                    Id = 4,
                    Title = "Club Recruitment Day",
                    Content = "On March 9, 2024, FST Errachidia held its Club Recruitment Day.\r\nClubs like IT, ENACTUS, The Great Debaters, Digigirlz, and BISOFT showcased their work.\r\nStudents engaged in creative, scientific, and social initiatives.\r\nThe event reflected the vibrant spirit of student life.\r\nFST proudly celebrates this energy and diversity.",
                    Author = "Mohamed Agdid",
                    PublishedDate = new DateTime(2024, 3, 9),
                    CategoryId = 4,
                    FeatureImagePath = "/images/events.jpg",
                    IdUser = "Null"
                }




            );
        }



    }
}

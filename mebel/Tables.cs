        using System.ComponentModel.DataAnnotations;

        public class Cinema
        {
            [Key]        
            public int ID { get; set; }
            public string? Name { get; set; }
            public string? Login { get; set; }
            public string? Password { get; set; }
            public string? Type { get; set; }

            public static Cinema? currentUser { get; set; }
        }

        public class mebels
        {
            [Key]
            public int id_mebel { get; set; }
            public string? artikul { get; set; }
            public string? name { get; set; }
            public string? kolichestvo { get; set; }
            
            public static mebels? currentUser1 { get; set; }
        }

        public class firma
        {
            [Key]
            public int id_firma { get; set; }
            public string? name_firm { get; set; }
            public string? country { get; set; }
            public static mebels? currentUser2 { get; set; }
        }


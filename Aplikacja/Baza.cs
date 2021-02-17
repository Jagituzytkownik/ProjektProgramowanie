using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Aplikacja
{
    [Table(Name = "Autorzy")]
    public class Autorzy
    {
        private int id_Autora;
        private string Autora;
        [Column(Storage = "id_Autora", DbType = "Int NOT NULL IDENTITY",
        IsPrimaryKey = true)]
        public int id_Autor
        {
            get { return this.id_Autora; }
            set { this.id_Autora = value; }
        }
        [Column(Storage = "Autora")]
        public string Autor
        {
            get { return this.Autora; }
            set { this.Autora = value; }
        }
    }


    [Table(Name = "Książki")]
    public class Książki
    {
        private int id_Książki;
        private int id_Tytuły;
        private int id_Autora;
        private int id_Kategories;
        [Column(Storage = "id_Książki", DbType = "Int identity NOT NULL IDENTITY", IsPrimaryKey = true)]
        public int id_Książka
        {
            get { return this.id_Książki; }
            set { this.id_Książki = value; }
        }
        [Column(Storage = "id_Tytuły")]
        public int id_Tytuł
        {
            get { return this.id_Tytuły; }
            set { this.id_Tytuły = value; }
        }
        [Column(Storage = "id_Autora")]
        public int id_Autor
        {
            get { return this.id_Autora; }
            set { this.id_Autora = value; }
        }
        [Column(Storage = "id_Kategories")]
        public int id_Kategorie
        {
            get { return this.id_Kategories; }
            set { this.id_Kategories = value; }
        }

        public override string ToString()
        {
            return $"{id_Książka} {id_Autor} {id_Tytuł} {id_Kategorie}";
        }
    }
    [Table(Name = "Tytuły")]
    public class Tytuły
    {
        private int id_Tytułs;
        private string Tytułs;
        [Column(Storage = "id_Tytułs", DbType = "Int NOT NULL IDENTITY",
        IsPrimaryKey = true)]
        public int id_Tytuł
        {
            get { return this.id_Tytułs; }
            set { this.id_Tytułs = value; }
        }
        [Column(Storage = "Tytułs")]
        public string Tytuł
        {
            get { return this.Tytułs; }
            set { this.Tytułs = value; }
        }
    }
    [Table(Name = "Kategoria")]
    public class Kategoria
    {
        private int id_Kategories;
        private string Kategories;
        [Column(Storage = "id_Kategories", DbType = "Int NOT NULL IDENTITY",
        IsPrimaryKey = true)]
        public int id_Kategorie
        {
            get { return this.id_Kategories; }
            set { this.id_Kategories = value; }
        }
        [Column(Storage = "Kategories")]
        public string Kategorie
        {
            get { return this.Kategories; }
            set { this.Kategories = value; }
        }
    }
    [Table(Name = "Klient")]
    public class Klient
    {
        private int id_Klients;
        private string Imies;
        private string Nazwiskos;
        private string Zamieszkanies;
        private string NrTelefonus;
        [Column(Storage = "id_Klients", DbType = "Int NOT NULL IDENTITY",
        IsPrimaryKey = true)]
        public int id_Klient
        {
            get { return this.id_Klients; }
            set { this.id_Klients = value; }
        }
        [Column(Storage = "Imies")]
        public string Imie
        {
            get { return this.Imies; }
            set { this.Imies = value; }
        }
        [Column(Storage = "Nazwiskos")]
        public string Nazwisko
        {
            get { return this.Nazwiskos; }
            set { this.Nazwiskos = value; }
        }
        [Column(Storage = "Zamieszkanies")]
        public string Zamieszkanie
        {
            get { return this.Zamieszkanies; }
            set { this.Zamieszkanies = value; }
        }
        [Column(Storage = "NrTelefonus")]
        public string NrTelefonu
        {
            get { return this.NrTelefonus; }
            set { this.NrTelefonus = value; }
        }
        public override string ToString()
        {
            return $"{id_Klient} {Imies} {Nazwiskos} {Zamieszkanies}";
        }
    }

    [Table(Name = "Wypożyczenia")]
    public class Wypożyczenia
    {
        private int id_Wypożyczenias;
        private int id_Klients;
        private int id_Książkas;
        private DateTime dataWypożyczenias;
        private DateTime dataOddanias;
        [Column(Storage = "id_Wypożyczenias", DbType = "Int NOT NULL IDENTITY",
        IsPrimaryKey = true)]
        public int id_Wypożyczenia
        {
            get { return this.id_Wypożyczenias; }
            set { this.id_Wypożyczenias = value; }
        }
        [Column(Storage = "id_Klients")]
        public int id_Klient
        {
            get { return this.id_Klients; }
            set { this.id_Klients = value; }
        }
        [Column(Storage = "id_Książkas")]
        public int id_Książka
        {
            get { return this.id_Książkas; }
            set { this.id_Książkas = value; }
        }
        [Column(Storage = "dataWypożyczenias", DbType = "date")]
        public DateTime dataWypożyczenia
        {
            get { return this.dataWypożyczenias; }
            set { this.dataWypożyczenias = value; }
        }
        [Column(Storage = "dataOddanias", DbType = "date")]
        public DateTime dataOddania
        {
            get { return this.dataOddanias; }
            set { this.dataOddanias = value; }
        }
        public override string ToString()
        {
            return $"{id_Wypożyczenia} {id_Klient} {id_Książka}";
        }
    }

}

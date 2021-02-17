using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Aplikacja
{
    /// <summary>
    /// Klasa stanowi pojemnik na dane z tabeli Autorzy
    /// </summary>
    [Table(Name = "Autorzy")]
    public class Autorzy
    {
        private int id_Autora;
        private string Autora;
        /// <summary>
        /// Właściwość pobiera id z tabeli Autorzy
        /// </summary>
        [Column(Storage = "id_Autora", DbType = "Int NOT NULL IDENTITY",
        IsPrimaryKey = true)]
        public int id_Autor
        {
            get { return this.id_Autora; }
            set { this.id_Autora = value; }
        }
        /// <summary>
        /// Właściwość pobiera Autor z tabeli Autorzy
        /// </summary>
        [Column(Storage = "Autora")]
        public string Autor
        {
            get { return this.Autora; }
            set { this.Autora = value; }
        }
    }

    /// <summary>
    /// Klasa stanowi pojemnik na dane z tabeli Książki
    /// </summary>
    [Table(Name = "Książki")]
    public class Książki
    {
        private int id_Książki;
        private int id_Tytuły;
        private int id_Autora;
        private int id_Kategories;
        /// <summary>
        /// Właściwość pobiera id z tabeli Książka
        /// </summary>
        [Column(Storage = "id_Książki", DbType = "Int identity NOT NULL IDENTITY", IsPrimaryKey = true)]
        public int id_Książka
        {
            get { return this.id_Książki; }
            set { this.id_Książki = value; }
        }
        /// <summary>
        /// Właściwość pobiera id tytuł z tabeli Książka
        /// </summary>
        [Column(Storage = "id_Tytuły")]
        public int id_Tytuł
        {
            get { return this.id_Tytuły; }
            set { this.id_Tytuły = value; }
        }
        /// <summary>
        /// Właściwość pobiera id autora z tabeli Książka
        /// </summary>
        [Column(Storage = "id_Autora")]
        public int id_Autor
        {
            get { return this.id_Autora; }
            set { this.id_Autora = value; }
        }
        /// <summary>
        /// Właściwość pobiera id kategorie z tabeli Książka
        /// </summary>
        [Column(Storage = "id_Kategories")]
        public int id_Kategorie
        {
            get { return this.id_Kategories; }
            set { this.id_Kategories = value; }
        }
        /// <summary>
        /// Właściwość pobiera id z tabeli Autorzy
        /// </summary>
        public override string ToString()
        {
            return $"{id_Książka} {id_Autor} {id_Tytuł} {id_Kategorie}";
        }
    }
    /// <summary>
    /// Klasa stanowi pojemnik na dane z tabeli Tytuły
    /// </summary>
    [Table(Name = "Tytuły")]
    public class Tytuły
    {
        private int id_Tytułs;
        private string Tytułs;
        /// <summary>
        /// Właściwość pobiera id z tabeli Tytuł
        /// </summary>
        [Column(Storage = "id_Tytułs", DbType = "Int NOT NULL IDENTITY",
        IsPrimaryKey = true)]
        public int id_Tytuł
        {
            get { return this.id_Tytułs; }
            set { this.id_Tytułs = value; }
        }
        /// <summary>
        /// Właściwość pobiera Tytuł z tabeli Tytuł
        /// </summary>
        [Column(Storage = "Tytułs")]
        public string Tytuł
        {
            get { return this.Tytułs; }
            set { this.Tytułs = value; }
        }
    }
    /// <summary>
    /// Klasa stanowi pojemnik na dane z tabeli Kategorie
    /// </summary>
    [Table(Name = "Kategoria")]
    public class Kategoria
    {
        private int id_Kategories;
        private string Kategories;
        /// <summary>
        /// Właściwość pobiera id z tabeli Kategoria
        /// </summary>
        [Column(Storage = "id_Kategories", DbType = "Int NOT NULL IDENTITY",
        IsPrimaryKey = true)]
        public int id_Kategorie
        {
            get { return this.id_Kategories; }
            set { this.id_Kategories = value; }
        }
        /// <summary>
        /// Właściwość pobiera Kategorie z tabeli Kategoria
        /// </summary>
        [Column(Storage = "Kategories")]
        public string Kategorie
        {
            get { return this.Kategories; }
            set { this.Kategories = value; }
        }
    }
    /// <summary>
    /// Klasa stanowi pojemnik na dane z tabeli Klienci
    /// </summary>
    [Table(Name = "Klient")]
    public class Klient
    {
        private int id_Klients;
        private string Imies;
        private string Nazwiskos;
        private string Zamieszkanies;
        private string NrTelefonus;
        /// <summary>
        /// Właściwość pobiera id z tabeli Klient
        /// </summary>
        [Column(Storage = "id_Klients", DbType = "Int NOT NULL IDENTITY",
        IsPrimaryKey = true)]
        public int id_Klient
        {
            get { return this.id_Klients; }
            set { this.id_Klients = value; }
        }
        /// <summary>
        /// Właściwość pobiera Imie z tabeli Klient
        /// </summary>
        [Column(Storage = "Imies")]
        public string Imie
        {
            get { return this.Imies; }
            set { this.Imies = value; }
        }
        /// <summary>
        /// Właściwość pobiera Nazwisko z tabeli Klient
        /// </summary>
        [Column(Storage = "Nazwiskos")]
        public string Nazwisko
        {
            get { return this.Nazwiskos; }
            set { this.Nazwiskos = value; }
        }
        /// <summary>
        /// Właściwość pobiera Zamieszkanie z tabeli Klient
        /// </summary>
        [Column(Storage = "Zamieszkanies")]
        public string Zamieszkanie
        {
            get { return this.Zamieszkanies; }
            set { this.Zamieszkanies = value; }
        }
        /// <summary>
        /// Właściwość pobiera NrTelefonu z tabeli Klient
        /// </summary>
        [Column(Storage = "NrTelefonus")]
        public string NrTelefonu
        {
            get { return this.NrTelefonus; }
            set { this.NrTelefonus = value; }
        }
        /// <summary>
        /// Pozwala wyświetlić dane
        /// </summary>
        public override string ToString()
        {
            return $"{id_Klient} {Imies} {Nazwiskos} {Zamieszkanies}";
        }
    }
    /// <summary>
    /// Klasa stanowi pojemnik na dane z tabeli Wypożyczenia
    /// </summary>
    [Table(Name = "Wypożyczenia")]
    public class Wypożyczenia
    {
        private int id_Wypożyczenias;
        private int id_Klients;
        private int id_Książkas;
        private DateTime dataWypożyczenias;
        private DateTime dataOddanias;
        /// <summary>
        /// Właściwość pobiera id z tabeli Wypożycznia
        /// </summary>
        [Column(Storage = "id_Wypożyczenias", DbType = "Int NOT NULL IDENTITY",
        IsPrimaryKey = true)]
        public int id_Wypożyczenia
        {
            get { return this.id_Wypożyczenias; }
            set { this.id_Wypożyczenias = value; }
        }
        /// <summary>
        /// Właściwość pobiera id klienta z tabeli Wypożycznia
        /// </summary>
        [Column(Storage = "id_Klients")]
        public int id_Klient
        {
            get { return this.id_Klients; }
            set { this.id_Klients = value; }
        }
        /// <summary>
        /// Właściwość pobiera id książki z tabeli Wypożyczenia
        /// </summary>
        [Column(Storage = "id_Książkas")]
        public int id_Książka
        {
            get { return this.id_Książkas; }
            set { this.id_Książkas = value; }
        }
        /// <summary>
        /// Właściwość pobiera dataWypożyczenia z tabeli Wypożyczenia
        /// </summary>
        [Column(Storage = "dataWypożyczenias", DbType = "date")]
        public DateTime dataWypożyczenia
        {
            get { return this.dataWypożyczenias; }
            set { this.dataWypożyczenias = value; }
        }
        /// <summary>
        /// Właściwość pobiera dataOddania z tabeli Wypożyczenia
        /// </summary>
        [Column(Storage = "dataOddanias", DbType = "date")]
        public DateTime dataOddania
        {
            get { return this.dataOddanias; }
            set { this.dataOddanias = value; }
        }
        /// <summary>
        /// Zwraca dane Wypożyczenia
        /// </summary>
        public override string ToString()
        {
            return $"{id_Wypożyczenia} {id_Klient} {id_Książka}";
        }
    }

}

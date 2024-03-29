﻿using System.Xml.Serialization;

namespace Theatre.DataProcessor.ExportDto
{
    [XmlType("Play")]
    public class PlaysExportModel
    {
        [XmlAttribute("Title")]
        public string Title { get; set; }

        [XmlAttribute("Duration")]
        public string Duration { get; set; }

        [XmlAttribute("Rating")]
        public string Rating { get; set; }

        [XmlAttribute("Genre")]
        public string Genre { get; set; }

        [XmlArray("Actors")]
        public ActorsModel[] Actors { get; set; }
    }

    [XmlType("Actor")]
    public class ActorsModel
    {
        [XmlAttribute("FullName")]
        public string FullName { get; set; }

        [XmlAttribute("MainCharacter")]
        public string MainCharacter { get; set; }
    }
}

//< Play Title = "A Raisin in the Sun" Duration = "01:40:00" Rating = "5.4" Genre = "Drama" >
//    < Actors >
//      < Actor FullName = "Sylvia Felipe" MainCharacter = "Plays main character in 'A Raisin in the Sun'." />
//      < Actor FullName = "Sella Mains" MainCharacter = "Plays main character in 'A Raisin in the Sun'." />
//      < Actor FullName = "Sela Hillett" MainCharacter = "Plays main character in 'A Raisin in the Sun'." />
//      < Actor FullName = "Rodney O'Neill" MainCharacter = "Plays main character in 'A Raisin in the Sun'." />
//      < Actor FullName = "Robbert Tuvey" MainCharacter = "Plays main character in 'A Raisin in the Sun'." />
//      < Actor FullName = "Reamonn Maleby" MainCharacter = "Plays main character in 'A Raisin in the Sun'." />
//      < Actor FullName = "Loutitia Joy" MainCharacter = "Plays main character in 'A Raisin in the Sun'." />
//      < Actor FullName = "Irving Houlridge" MainCharacter = "Plays main character in 'A Raisin in the Sun'." />
//      < Actor FullName = "Cristine Van Brug" MainCharacter = "Plays main character in 'A Raisin in the Sun'." />
//      < Actor FullName = "Clerissa Fellgate" MainCharacter = "Plays main character in 'A Raisin in the Sun'." />
//      < Actor FullName = "Caye Blacklawe" MainCharacter = "Plays main character in 'A Raisin in the Sun'." />
//    </ Actors >
//  </ Play >


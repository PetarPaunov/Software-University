﻿namespace SoftJail.DataProcessor.ExportDto
{
    public class PrisonersOfficersExportModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CellNumber { get; set; }

        public OfficersExportModel[] Officers { get; set; }

        public decimal TotalOfficerSalary { get; set; }
    }

    public class OfficersExportModel
    {                       
        public string OfficerName { get; set; }
        public string Department { get; set; }
    }
}

//    "Id": 3,
//    "Name": "Binni Cornhill",
//    "CellNumber": 503,
//    "Officers": [
//      {
//        "OfficerName": "Hailee Kennon",
//        "Department": "ArtificialIntelligence"
//      },
//      {
//    "OfficerName": "Theo Carde",
//        "Department": "Blockchain"
//      }
//    ],
//    "TotalOfficerSalary": 7127.93


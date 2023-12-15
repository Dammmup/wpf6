using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public partial class NinjaApiAnimal1
    {
        public string Name { get; set; }
        public Taxonomy Taxonomy { get; set; }
        public string[] Locations { get; set; }
        public Characteristics Characteristics { get; set; }
    }

    public partial class Characteristics1
    {
        public string Prey { get; set; }
        public string NameOfYoung { get; set; }
        public string GroupBehavior { get; set; }
        public string EstimatedPopulationSize { get; set; }
        public string BiggestThreat { get; set; }
        public string MostDistinctiveFeature { get; set; }
        public string GestationPeriod { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
        public long AverageLitterSize { get; set; }
        public string Lifestyle { get; set; }
        public string CommonName { get; set; }
        public long NumberOfSpecies { get; set; }
        public string Location { get; set; }
        public string Slogan { get; set; }
        public string Group { get; set; }
        public string Color { get; set; }
        public string SkinType { get; set; }
        public string TopSpeed { get; set; }
        public string Lifespan { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string AgeOfSexualMaturity { get; set; }
        public string AgeOfWeaning { get; set; }
    }

    public partial class Taxonomy1
    {
        public string Kingdom { get; set; }
        public string Phylum { get; set; }
        public string Class { get; set; }
        public string Order { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string ScientificName { get; set; }
    }
}


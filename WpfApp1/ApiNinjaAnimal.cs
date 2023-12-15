using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public partial class ApiNinjaAnimal
    {
        public string Name { get; set; }
        public Taxonomy Taxonomy { get; set; }
        public string[] Locations { get; set; }
        public Characteristics Characteristics { get; set; }
    }

    public partial class Characteristics
    {
        public string DistinctiveFeature { get; set; }
        public string Temperament { get; set; }
        public string Training { get; set; }
        public Diet Diet { get; set; }
        public string AverageLitterSize { get; set; }
        public string Type { get; set; }
        public string CommonName { get; set; }
        public string Slogan { get; set; }
        public string Group { get; set; }
        public string Color { get; set; }
        public SkinType SkinType { get; set; }
        public string Lifespan { get; set; }
        public string MainPrey { get; set; }
        public string NameOfYoung { get; set; }
        public string Habitat { get; set; }
        public string Predators { get; set; }
        public string Lifestyle { get; set; }
        public string FavoriteFood { get; set; }
        public string TopSpeed { get; set; }
        public string Weight { get; set; }
        public string Length { get; set; }
        public string Prey { get; set; }
        public string GroupBehavior { get; set; }
        public string EstimatedPopulationSize { get; set; }
        public string BiggestThreat { get; set; }
        public string MostDistinctiveFeature { get; set; }
        public string GestationPeriod { get; set; }
        public string LitterSize { get; set; }
        public string Location { get; set; }
        public string Height { get; set; }
        public string AgeOfSexualMaturity { get; set; }
        public string AgeOfWeaning { get; set; }
        public string OtherNameS { get; set; }
        public long? NumberOfSpecies { get; set; }
    }

    public partial class Taxonomy
    {
        public Kingdom Kingdom { get; set; }
        public Phylum Phylum { get; set; }
        public Class Class { get; set; }
        public Order Order { get; set; }
        public Family Family { get; set; }
        public string Genus { get; set; }
        public string ScientificName { get; set; }
    }

    public enum Diet { Carnivore, Herbivore, Omnivore };

    public enum SkinType { Fur, Hair, Scales };

    public enum Class { Mammalia, Reptilia };

    public enum Family { Canidae, Colubridae, Pteropodidae, Sciuridae };

    public enum Kingdom { Animalia };

    public enum Order { Carnivora, Chiroptera, Rodentia, Squamata };

    public enum Phylum { Chordata };
}



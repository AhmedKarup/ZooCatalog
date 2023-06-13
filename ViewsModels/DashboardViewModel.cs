using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp12.ViewsModels
{
    public partial class DashboardViewModel : BaseViewModel
    {

        public ObservableCollection<Category> Categories { get; } = new ObservableCollection<Category>();

        public ObservableCollection<Animal> AnimalsCopy = new();
        public ObservableCollection<Animal> Animals { get; set; } = new ObservableCollection<Animal>();

        [ObservableProperty]
        public Animal animal;
        
        public DashboardViewModel()
        {
            AddCategories();
            AddAnimals();

        }

        [ObservableProperty]
        public Category selectedCategory;

        [RelayCommand]
        public void ChangeCategorie()
        {
            
            if (SelectedCategory.Name == "All")
            {
                try
                {
                    Animals.Clear();
                    foreach (Animal animal in AnimalsCopy)
                    {
                        Animals.Add(animal);
                    }
                }
                catch (Exception) {
                    Console.WriteLine("ERROR IN FIRST");
                }

            }
            else
            {
                try
                {
                    List<Animal> filteredAnimals = AnimalsCopy.Where(animal => animal.Category.Name == SelectedCategory.Name).ToList();
                    Animals.Clear();
                    foreach (Animal animal in filteredAnimals)
                    {
                        Animals.Add(animal);
                    }
                }
                catch (Exception) {
                    Console.WriteLine("Error in second");
                }

            }
        }

        public void AddAnimals()
        {
            Animals.Add(new Animal("lion1.jpg", "Asiatic lion", "Gir National Park and Wildlife Sanctuary", "7km", "700", "4.3", "170-250m", "110–190kg", "72km/h","The Asiatic lion, also known as the Persian lion,is a population of Panthera leo leo that today survives in the wild only in India. Since the turn of the 20th century, its range has been restricted to Gir National Park and the surrounding areas in the Indian state of Gujarat. Historically, it inhabited much of southwest Asia to northern India.The Asiatic lion's fur ranges in colour from ruddy-tawny, heavily speckled with black, to sandy or buffish grey, sometimes with a silvery sheen in certain lighting. Males have only moderate mane growth at the top of the head, so that their ears are always visible.", Categories[1], 21.126356177084826, 70.82410094325276));
            Animals.Add(new Animal("lion2.jpg", "Transvaal lion", "Africa,Namibia,Mozambique,South Africa", "7km", "00", "4.2", "2.6–3.20m", "150–250 kg", "68km/h", "The Transvaal lion (Panthera leo krugeri), also called the Kruger, South African or Southeast African lion is a subspecies of the lion that reportedly lives in southern Africa, including Kruger National Park and Hlane Royal National Park. Lions of the Kalahari Region may be either Panthera leo krugeri or Panthera leo bleyenberghi. It is named after the Transvaal region in South Africa. The male usually has a well-developed mane. Most of them are black-maned as well. ", Categories[1], 45.52968132655297, -122.72492410147015));
            Animals.Add(new Animal("lion3.jpg", "Katanga lion", " Africa-deserts,grasslands,forests,mountains", "7km", "600", "4.0", "2,3-2,5m", " 105 - 170 kg", "81 km/h", "The Katanga lion (Panthera leo bleyenberghi), or Southwest African lion, is a subspecies of the lion that lives in southwestern Africa. It is found in Namibia, Angola, Zaire, western Zambia, western Zimbabwe and northern Botswana. The type specimen was from Katanga (Zaire). Lions in the Kalahari xeric savanna may be either Panthera leo bleyenberghi or Panthera leo krugeri. In 2008, surveys were conducted in the Upemba and Kundelungu National Parks located in the Democratic Republic of the Congo, but no evidence of lion presence was found.", Categories[1], 8.091861763198839, 3.1611407729926904));
            Animals.Add(new Animal("tiger1", "Bengal tiger", "India, Bangladesh, Bhutan, and Nepal.", "7km", "600", "4.7", "90–110 cm", "220-260kg", "35 to 40 mph", "The Bengal tiger is a subspecies of tiger that’s native to the Indian subcontinent. Also known as the Indian tiger, and previously the royal Bengal tiger, the species is the most numerous of the tiger species. However, the species is still endangered, and there are estimated to be between just 2,603–3,346 individuals remaining.Bengal tigers have been present on the Indian subcontinent for around 12,000 to 16,500 years. They’re considered to be one of the world’s charismatic megafauna - that is, a large animal species with symbolic value and popular appeal.", Categories[2], 23.956136301960306, 72.55995038220904));
            Animals.Add(new Animal("tiger2", "Siberian Tiger", "Eastern Russia", "7km", "50", "4.4", "1.70-2.08m", "118-318 kg", "80km/h", "The Siberian tiger or Amur tiger (Panthera tigris tigris) is the largest felid in the world. They live in eastern Russia's birch forests, and there are some in China and North Korea. It is estimated that there are around 400 to 500 Siberian tigers left in the wild.Siberian tigers are the largest of all tigers, as well as the largest of all the big cats. They can grow up to the length of 6–9 ft (1.8–2.7 meters), but some can be as long as 11 feet (3.4 m). ", Categories[2], 31.663334813406422, 75.05641780619052));
            Animals.Add(new Animal("tiger3", "Sumatran tiger", "island of Sumatra in Indonesia.", "7km", "400 to 600", "3.1", "2.4m", "120kg", "65 km/h", "The Sumatran tiger is a population of Panthera tigris sondaica on the Indonesian island of Sumatra. It is the only surviving tiger population in the Sunda Islands, where the Bali and Javan tigers are extinct.Sequences from complete mitochondrial genes of 34 tigers support the hypothesis that Sumatran tigers are diagnostically distinct from mainland subspecies.In 2017, the Cat Classification Task Force of the Cat Specialist Group revised felid taxonomy and recognizes the living and extinct tiger populations in Indonesia ", Categories[2], -6.05043002549632, 106.76925636610885));
            Animals.Add(new Animal("tiger4.jpeg ", "Indochinese tiger", "Thailand and Myanmar", "7km", "350", "4.5", "2.55-2.85m", "100 to 130 kg", "65 km/ h", "The Indochinese tiger is a population of the Panthera tigris tigris subspecies that is native to Southeast Asia.This population occurs in Myanmar, Thailand and Laos. In 2011, the population was thought to comprise 342 individuals, including 85 in Myanmar and 20 in Vietnam, with the largest population unit surviving in Thailand, estimated at 189 to 252 individuals during the period 2009 to 2014.The Indochinese tiger's ground colouration is darker, with more rather short and narrow single stripes; its skull is smaller than that of the Bengal tiger.", Categories[2], 17.854237073863718, 83.3337635288681));
            Animals.Add(new Animal("wolf1.jpg", "Eurasian wolf", "Western Europe, Scandinavia, Russia, China,", "7km", "30,000", "4.2", "105–160 cm", "69–80 kg", "36-38 mph", "The Eurasian wolf (Canis lupus lupus), also known as the common wolf, is a subspecies of grey wolf native to Europe and Asia. It was once widespread throughout Eurasia prior to the Middle Ages. Aside from an extensive paleontological record, Indo-European languages typically have several words for \"wolf\", thus attesting to the animal's abundance and cultural significance.It was held in high regard in Baltic, Celtic, Slavic, Turkic, ancient Greek, Roman, and Thracian cultures, whilst having an ambivalent reputation in early Germanic cultures", Categories[3], 35.49267603758559, 139.5225771678628));
            Animals.Add(new Animal("wolf2.jpg", "Arctic wolf", "Arctic regions of North America and Greenland.", "7km", "200,000", "4.7", "0.90m", "34–46 kg", "46 mph", "The Arctic wolf (Canis lupus arctos), also known as the white wolf or polar wolf, is a subspecies of grey wolf native to the High Arctic tundra of Canada's Queen Elizabeth Islands, from Melville Island to Ellesmere Island.Unlike some populations that move between tundra and forest regions,Arctic wolves spend their entire lives north of the northern treeline.Their distribution to south is limited to the northern fringes of the Middle Arctic tundra on the southern half of Prince of Wales and Somerset Islands.[2] It is a medium-sized subspecies, distinguished from the northwestern wolf by its smaller size, its whiter colouration, its narrower braincase,and larger carnassials.Since 1930, there has been a progressive reduction in size in Arctic wolf skulls, which is likely the result of wolf-dog hybridization.", Categories[3], 43.823090562232046, -79.18517704711105));
            Animals.Add(new Animal("wolf3.jpg", "Eastern wolf", "Algonquin Provincial Park", "7km", "1000 ", "4.4", "63-91 cm", "30kg", "40 mph", "The eastern wolf (Canis lycaon or Canis lupus lycaonor Canis rufus lycaon) also known as the timber wolf,Algonquin wolf or eastern timber wolf,is a canine of debated taxonomy native to the Great Lakes region and southeastern Canada. It is considered to be either a unique subspecies of gray wolf or red wolf or a separate species from both. Many studies have found the eastern wolf to be the product of ancient and recent genetic admixture between the gray wolf and the coyote,while other studies have found some or all populations of the eastern wolf, as well as coyotes, originally separated from a common ancestor with the wolf over 1 million years ago and that these populations of the eastern wolf may be the same species as or a closely related species to the red wolf (Canis lupus rufus or Canis rufus) of the Southeastern United States.", Categories[3], 44.66738401187691, -88.07916704576475));
            Animals.Add(new Animal("wolf4.jpg", "Northwestern wolf", "western United States, western Canada, and Alaska,", "7km", "7,000-11,200", "4.6", "68-91 cm", "66 kg", "40mph", "The northwestern wolf (Canis lupus occidentalis), also known as the Mackenzie Valley wolf,Alaskan timber wolf,or Canadian timber wolf,is a subspecies of gray wolf in western North America. Arguably the largest grey wolf subspecies in the world, it ranges from Alaska, the upper Mackenzie River Valley; southward throughout the western Canadian provinces, aside from prairie landscapes in its southern portions, as well as the Northwestern United States", Categories[3], 43.0, 18.0));
            Animals.Add(new Animal("gorilla1.jpg", "Eastern gorilla", "lowland tropical rainforests in the eastern DRC", "7km", "1.000-6.000", "4.8", "1.7 m", "140–205.5 kg", "40 km/h", "The eastern gorilla (Gorilla beringei) is a critically endangered species of the genus Gorilla and the largest living primate. At present, the species is subdivided into two subspecies. There are 6,800 eastern lowland gorillas or Grauer’s gorillas (G. b. graueri) and 1,000 mountain gorillas (G. b. beringei).Illegal hunting threatens the species.There are two recognised subspecies of eastern gorilla: the mountain gorilla (Gorilla beringei beringei) of the volcanic slopes of Rwanda, Uganda and eastern Democratic Republic of Congo; and the eastern lowland gorilla or Grauer's gorilla (Gorilla beringei graueri) in eastern Democratic Republic of Congo.", Categories[4], 43.0, 18.0));
            Animals.Add(new Animal("gorilla2.jpg", "Western gorilla", "equatorial Africa", "7km", "100,000", "4.7", "1.8 meters", "160kg", "40 km/h", "The western gorilla (Gorilla gorilla) is a great ape found in Africa, one of two species of the hominid genus Gorilla. Large and robust with males weighing around 168 kilograms (370 lb), the hair is significantly lighter in color than the eastern gorilla, Gorilla beringei, and geographically isolated from them in a region at the midwest of the African continent. Two subspecies are recognised, Gorilla gorilla diehli (Cross River gorilla) is limited to a smaller range in the north at the border of Cameroon and Nigeria. Both subspecies are listed Critically Endangered.", Categories[4], 43.0, 18.0));
            Animals.Add(new Animal("monkey1.jpg", "Proboscis monkey", " Borneo", "7km", "7,000", "4.2", "70cm", "20kg", "15mph", "The proboscis monkey (Nasalis larvatus) or long-nosed monkey is an arboreal Old World monkey with an unusually large nose, a reddish-brown skin color and a long tail. It is endemic to the southeast Asian island of Borneo and is found mostly in mangrove forests and on the coastal areas of the island.This species co-exists with the Bornean orangutan and monkeys such as the silvery lutung.It belongs in the monotypic genus Nasalis.", Categories[5], 43.0, 18.0));
            Animals.Add(new Animal("monkey2.jpg", "Mandrill", "west central Africa,Equatorial Guinea, Cameroon", "7km", "4,000 ", "4.0", "55-65cm", "19-37kg", "25mph", "The mandrill (Mandrillus sphinx) is a large Old World monkey native to west central Africa. It is one of the most colorful mammals in the world, with red and blue skin on its face and posterior. The species is sexually dimorphic, as males have a larger body, longer canine teeth and brighter coloring. Its closest living relative is the drill with which it shares the genus Mandrillus. Both species were traditionally thought to be baboons, but further evidence has shown that they are more closely related to white-eyelid mangabeys.", Categories[5], 43.0, 18.0));
            Animals.Add(new Animal("monkey3.jpg", "Panamanian Capuchin", "Central America1", "7km", "60", "4.2", "81 cm", "2.9–3.9kg", "34 mph", "The Panamanian white-faced capuchin (Cebus imitator), also known as the Panamanian white-headed capuchin or Central American white-faced capuchin, is a medium-sized New World monkey of the family Cebidae, subfamily Cebinae. Native to the forests of Central America, the white-faced capuchin is important to rainforest ecology for its role in dispersing seeds and pollen.\r\n\r\nAmong the best known monkeys, the Panamanian white-faced capuchin is recognized as the typical companion to the organ grinder. In recent years the species has become popular in American media, particularly in the Pirates of the Caribbean film series. It is a highly intelligent monkey and has been trained to assist paraplegic persons. It is a medium-sized monkey, weighing up to 3.9 kg (8 lb 10 oz). ", Categories[5], 30.18800383241164, -85.78083047605416));
            Animals.Add(new Animal("monkey4.jpg", "Bonnet macaque", "southern India", "7km", "170,000", "4.7", "45 cm", "6.7 kg.", "30mph", "The bonnet macaque (Macaca radiata), also known as zati,is a species of macaque endemic to southern India. Its distribution is limited by the Indian Ocean on three sides and the Godavari and Tapti Rivers, along with its related competitor the rhesus macaque in the north.Land use changes in the last few decades have resulted in changes in its distribution boundaries with the rhesus macaque, raising concern for its status in the wild.", Categories[5], 18.44619681536675, 73.85905470965528));
            Animals.Add(new Animal("bear1.jpg", "Brown bear", "Western Europe,Asia,Himalayan Mountains,", "7km", "200,000", "4.8", "70–150 cm", "80–600 kg", "56 km/h", "The brown bear (Ursus arctos) is a large bear species found across Eurasia and North America.In North America, the populations of brown bears are called grizzly bears, while the subspecies that inhabits the Kodiak Islands of Alaska is known as the Kodiak bear. It is one of the largest living terrestrial members of the order Carnivora, rivaled in size only by its closest relative, the polar bear (Ursus maritimus), which is much less variable in size and slightly bigger on average.The brown bear's range includes parts of Russia, Central Asia, the Himalayas, China, Canada, the United States, Hokkaido, Scandinavia, Finland, the Balkans, the Picos de Europa and the Carpathian region (especially Romania), Iran, Anatolia, and the Caucasus.", Categories[6], 40.848948643833545, -73.87750984539971));
            Animals.Add(new Animal("bear2.jpg", "American black bear", "Pacific Northwest's forests and mountains.", "7km", "300,000", "4.8", "70 to 105 cm", "59 – 300 kg", "30 mph", "DESCRIPTION", Categories[6], 43.0, 18.0));
            Animals.Add(new Animal("bear3.jpg", "Polar bear", "north of the Arctic Circle to the North Pole.", "7km", "26,000 ", "4.2", "1.8-2.4m", "450kg", "40 km/h", "The polar bear (Ursus maritimus) is a hypercarnivorous species of bear. Its native range lies largely within the Arctic Circle, encompassing the Arctic Ocean and its surrounding seas and landmasses, which includes the northernmost regions of North America and Eurasia. It is the largest extant bear species, as well as the largest extant land carnivore.A boar (adult male) weighs around 350–700 kg (770–1,540 lb),while a sow (adult female) is about half that size. Although it is the sister species of the brown bear,it has evolved to occupy a narrower ecological niche, with many body characteristics adapted for cold temperatures, for moving across snow, ice and open water, and for hunting seals, which make up most of its diet.", Categories[6], 40.66594916270499, -73.9597516713223));
            Animals.Add(new Animal("bear4.jpg", "Asian black bear", "Afghanistan, Bangladesh, Cambodia, China, India, Japan,", "7km", "50,000", "4.9", "120-140 cm", "60–200 kg", "25mph", "The Asian black bear (Ursus thibetanus), also known as the Asiatic black bear, moon bear and white-chested bear, is a medium-sized bear species native to Asia that is largely adapted to an arboreal lifestyle.It lives in the Himalayas, southeastern Iran, the northern parts of the Indian subcontinent, the Korean Peninsula, China, the Russian Far East, the islands of Honshū and Shikoku in Japan, and Taiwan. It is listed as vulnerable on the IUCN Red List, and is threatened by deforestation and poaching for its body parts, which are used in traditional medicine.", Categories[6], 26.13865150412714, 119.28896299767835));
            Animals.Add(new Animal("elephant1.jpg", "African bush elephant", "Botswana, Zimbabwe, Tanzania, Kenya, Namibia,", "7km", "415,000", "3.7", "3.2m", "3.000-6.000kg", "40 km/h", "The African bush elephant (Loxodonta africana), also known as the African savanna elephant, is one of two extant African elephant species and one of three extant elephant species. It is the largest living terrestrial animal, with bulls reaching a shoulder height of up to 3.96 m (13 ft 0 in) and a body mass of up to 10.4 t (11.5 short tons).It is distributed across 37 African countries and inhabits forests, grasslands and woodlands, wetlands and agricultural land. Since 2021, it has been listed as Endangered on the IUCN Red List. It is threatened foremost by habitat destruction, and in parts of its range also by poaching for meat and ivory.", Categories[7], -25.71946538174086, 27.804459827039295));
            Animals.Add(new Animal("elephant2.jpg", "Asian elephant", "Southeast Asia, including Sumatra and Borneo.", "7km", "50,000 ", "3.8", "2.75 m ", "4000kg", "15 mph", "The Asian elephant (Elephas maximus), also known as the Asiatic elephant, is the only living species of the genus Elephas and is distributed throughout the Indian subcontinent and Southeast Asia, from India in the west, Nepal in the north, Sumatra in the south, and to Borneo in the east. Three subspecies are recognised—E. m. maximus from Sri Lanka, E. m. indicus from mainland Asia and E. m. sumatranus from the island of Sumatra.Formerly, there was also the Syrian elephant or Western Asiatic elephant (Elephas maximus asurus) which was the westernmost population of the Asian elephant (Elephas maximus). This subspecies became extinct in ancient times.", Categories[7], 40.8472418052188, -73.87340312820591));
            Animals.Add(new Animal("elephant3.jpg", "African forest elephant", " West and Central Africa", "7km", "415,000", "3.6", "2.4–3m", "5,400 kg", "24mph", "The African forest elephant (Loxodonta cyclotis) is one of the two living African elephant species. It is native to humid forests in West Africa and the Congo Basin. It is the smallest of the three living elephant species, reaching a shoulder height of 2.4 m (7 ft 10 in). Both sexes have straight, down-pointing tusks, which erupt when they are 1–3 years old. It lives in family groups of up to 20 individuals. Since it forages on leaves, seeds, fruit, and tree bark, it has been referred to as the 'megagardener of the forest'. It contributes significantly to maintain the composition and structure of the Guinean Forests of West Africa and the Congolese rainforests.", Categories[7], -34.022269672101125, 23.26695604664072));          
            Animals.Add(new Animal("eagle1.jpg", "Golden eagle", "North America and Eurasia.", "7km", "30,000", "4.7", "38-53cm", "3.6-6.7kg", "320 km/h", "The golden eagle (Aquila chrysaetos) is a bird of prey living in the Northern Hemisphere. It is the most widely distributed species of eagle. Like all eagles, it belongs to the family Accipitridae. They are one of the best-known birds of prey in the Northern Hemisphere. These birds are dark brown, with lighter golden-brown plumage on their napes. Immature eagles of this species typically have white on the tail and often have white markings on the wings. Golden eagles use their agility and speed combined with powerful feet and large, sharp talons to hunt a variety of prey, mainly hares, rabbits, and marmots and other ground squirrels.", Categories[8], 61.12399329807236, -149.7924344620416));
            Animals.Add(new Animal("eagle2.jpg", "Barn owl", "Field edges, the edges of watercourses, ", "7km", "9,000", "3.6", "32-40 cm", "430–620 g", "10-20 mph", "The barn owl (Tyto alba) is the most widely distributed species of owl in the world and one of the most widespread of all species of birds, being found almost everywhere except for the polar and desert regions, Asia north of the Himalayas, most of Indonesia, and some Pacific Islands. It is also known as the common barn owl, to distinguish it from the other species in its family, Tytonidae, which forms one of the two main lineages of living owls, the other being the typical owls (Strigidae).There are at least three major lineages of barn owl: the western barn owl of Europe, western Asia, and Africa; the eastern barn owl of southeastern Asia and Australasia; and the American barn owl of the Americas. Some taxonomic authorities classify barn owls differently, recognising up to five separate species; and further research needs to be done to resolve the disparate taxonomies.", Categories[8], 54.587306192991015, -1.085548396276202));
            Animals.Add(new Animal("eagle3.jpg", "Osprey", "Alaska to Nova Scotia south to the Great Lakes", "7km", "1,200,000", "3.6", "180 cm", "0.9–2.1 kg", "30mph", "The osprey (Pandion haliaetus),also called sea hawk, river hawk, and fish hawk, is a diurnal, fish-eating bird of prey with a cosmopolitan range. It is a large raptor, reaching more than 60 cm (24 in) in length and 180 cm (71 in) across the wings. It is brown on the upperparts and predominantly greyish on the head and underparts.\r\n\r\nThe osprey tolerates a wide variety of habitats, nesting in any location near a body of water providing an adequate food supply. It is found on all continents except Antarctica, although in South America it occurs only as a non-breeding migrant.", Categories[8], 54.35146413147852, -2.986233526738598));
            Animals.Add(new Animal("snake1.jpg", "Copperhead", "Lokacija1", "7km", "600", "rating", "visina", "tezina", "brzina", "DESCRIPTION", Categories[9], 43.0, 18.0));
            Animals.Add(new Animal("snake2.jpg", "Black rat", "Lokacija1", "7km", "600", "rating", "visina", "tezina", "brzina", "DESCRIPTION", Categories[9], 43.0, 18.0));
            Animals.Add(new Animal("snake3.jpg", "Black mamba", "Lokacija1", "7km", "600", "rating", "visina", "tezina", "brzina", "DESCRIPTION", Categories[9], 43.0, 18.0));
            Animals.Add(new Animal("snake4.jpg", "Green anaconda", "Lokacija1", "7km", "600", "rating", "visina", "tezina", "brzina", "DESCRIPTION", Categories[9], 43.0, 18.0));
            Animals.Add(new Animal("zebra1.jpg", "Mountain zebra", "Lokacija1", "7km", "600", "rating", "visina", "tezina", "brzina", "DESCRIPTION", Categories[10], 43.0, 18.0));
            Animals.Add(new Animal("zebra2.jpg", "Grévy's zebra", "Lokacija1", "7km", "600", "rating", "visina", "tezina", "brzina", "DESCRIPTION", Categories[10], 43.0, 18.0));
            Animals.Add(new Animal("zebra3.jpg", "Plains zebra", "Lokacija1", "7km", "600", "rating", "visina", "tezina", "brzina", "DESCRIPTION", Categories[10], 43.0, 18.0));
            Animals.Add(new Animal("lizard1.jpg", "Komodo dragon", "Lokacija1", "7km", "600", "rating", "visina", "tezina", "brzina", "DESCRIPTION", Categories[11], 43.0, 18.0));
            Animals.Add(new Animal("lizard2.jpg", "Green iguana", "Lokacija1", "7km", "600", "rating", "visina", "tezina", "brzina", "DESCRIPTION", Categories[11], 43.0, 18.0));
            Animals.Add(new Animal("lizard3.jpg", "Marine iguana", "Lokacija1", "7km", "600", "rating", "visina", "tezina", "brzina", "DESCRIPTION", Categories[11], 43.0, 18.0));
            Animals.Add(new Animal("lizard4.jpg", "Sand lizard", "Lokacija1", "7km", "600", "rating", "visina", "tezina", "brzina", "DESCRIPTION", Categories[11], 43.0, 18.0));
            





            foreach (Animal animal in Animals)
            {
                AnimalsCopy.Add(animal);
            }

        }
        public void AddCategories()
        {
            Categories.Add(new Category("all", "All"));//0
            Categories.Add(new Category("intro1.jpg", "Lions")); //1
            Categories.Add(new Category("tigerlogo", "Tigers")); //2
            Categories.Add(new Category("wolflogo", "Wolfs"));//3
            Categories.Add(new Category("gorillalogo", "Gorillas"));//4
            Categories.Add(new Category("monkeylogo", "Monkeys")); //5
            Categories.Add(new Category("bearlogo", "Bears"));//6
            Categories.Add(new Category("elephantlogo", "Elephants"));//7       
            Categories.Add(new Category("birdlogo", "Birds"));//8
            Categories.Add(new Category("snakelogo", "Snakes"));//9         
            Categories.Add(new Category("zebralogo", "Zebras"));//10         
            Categories.Add(new Category("lizardlogo", "Lizards"));//11
           


            SelectedCategory = Categories[0];
        }


    }
}




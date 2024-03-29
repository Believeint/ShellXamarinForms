﻿using ShellXamarinForms.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShellXamarinForms.Data
{
    public static class PrimatasData
    {
        public static IList<Animal> Primatas { get; private set; }
        static PrimatasData()
        {
            Primatas = new List<Animal>();

            Primatas.Add(new Animal
            {
                Nome = "Baboon",
                Localizacao = "Africa & Asia",
                Detalhes = "Baboons are African and Arabian Old World Primatas belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                UrlImagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Capuchin Monkey",
                Localizacao = "Central & South America",
                Detalhes = "The capuchin Primatas are New World Primatas of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                UrlImagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Blue Monkey",
                Localizacao = "Central and East Africa",
                Detalhes = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
                UrlImagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Squirrel Monkey",
                Localizacao = "Central & South America",
                Detalhes = "The squirrel Primatas are the New World Primatas of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The Nome of the genus Saimiri is of Tupi origin, and was also used as an English Nome by early researchers.",
                UrlImagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Golden Lion Tamarin",
                Localizacao = "Brazil",
                Detalhes = "The golden lion tamarin also known as the golden marmoset, is a small New World monkey of the family Callitrichidae.",
                UrlImagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Howler Monkey",
                Localizacao = "South America",
                Detalhes = "Howler Primatas are among the largest of the New World Primatas. Fifteen species are currently recognised. Previously classified in the family Cebidae, they are now placed in the family Atelidae.",
                UrlImagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Japanese Macaque",
                Localizacao = "Japan",
                Detalhes = "The Japanese macaque, is a terrestrial Old World monkey species native to Japan. They are also sometimes known as the snow monkey because they live in areas where snow covers the ground for months each",
                UrlImagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Mandrill",
                Localizacao = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
                Detalhes = "The mandrill is a primate of the Old World monkey family, closely related to the baboons and even more closely to the drill. It is found in southern Cameroon, Gabon, Equatorial Guinea, and Congo.",
                UrlImagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Proboscis Monkey",
                Localizacao = "Borneo",
                Detalhes = "The proboscis monkey or long-nosed monkey, known as the bekantan in Malay, is a reddish-brown arboreal Old World monkey that is endemic to the south-east Asian island of Borneo.",
                UrlImagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Red-shanked Douc",
                Localizacao = "Vietnam, Laos",
                Detalhes = "The red-shanked douc is a species of Old World monkey, among the most colourful of all primates. This monkey is sometimes called the \"costumed ape\" for its extravagant appearance. From its knees to its ankles it sports maroon-red \"stockings\", and it appears to wear white forearm length gloves. Its attire is finished with black hands and feet. The golden face is framed by a white ruff, which is considerably fluffier in males. The eyelids are a soft powder blue. The tail is white with a triangle of white hair at the base. Males of all ages have a white spot on both sides of the corners of the rump patch, and red and white genitals.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Portrait_of_a_Douc.jpg/159px-Portrait_of_a_Douc.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Gray-shanked Douc",
                Localizacao = "Vietnam",
                Detalhes = "The gray-shanked douc langur is a douc species native to the Vietnamese provinces of Quảng Nam, Quảng Ngãi, Bình Định, Kon Tum, and Gia Lai. The total population is estimated at 550 to 700 individuals. In 2016, Dr Benjamin Rawson, Country Director of Fauna & Flora International - Vietnam Programme, announced a discovery of an additional population of more than 500 individuals found in Central Vietnam, bringing the total population up to approximately 1000 individuals.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Cuc.Phuong.Primate.Rehab.center.jpg/320px-Cuc.Phuong.Primate.Rehab.center.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Golden Snub-nosed Monkey",
                Localizacao = "China",
                Detalhes = "The golden snub-nosed monkey is an Old World monkey in the Colobinae subfamily. It is endemic to a small area in temperate, mountainous forests of central and Southwest China. They inhabit these mountainous forests of Southwestern China at elevations of 1,500-3,400 m above sea level. The Chinese Nome is Sichuan golden hair monkey. It is also widely referred to as the Sichuan snub-nosed monkey. Of the three species of snub-nosed Primatas in China, the golden snub-nosed monkey is the most widely distributed throughout China.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Black Snub-nosed Monkey",
                Localizacao = "China",
                Detalhes = "The black snub-nosed monkey, also known as the Yunnan snub-nosed monkey, is an endangered species of primate in the family Cercopithecidae. It is endemic to China, where it is known to the locals as the Yunnan golden hair monkey and the black golden hair monkey. It is threatened by habitat loss. It was named after Bishop Félix Biet.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/RhinopitecusBieti.jpg/320px-RhinopitecusBieti.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Tonkin Snub-nosed Monkey",
                Localizacao = "Vietnam",
                Detalhes = "The Tonkin snub-nosed monkey or Dollman's snub-nosed monkey is a slender-bodied arboreal Old World monkey, endemic to northern Vietnam. It is a black and white monkey with a pink nose and lips and blue patches round the eyes. It is found at altitudes of 200 to 1,200 m (700 to 3,900 ft) on fragmentary patches of forest on craggy limestone areas. First described in 1912, the monkey was rediscovered in 1990 but is exceedingly rare. In 2008, fewer than 250 individuals were thought to exist, and the species was the subject of intense conservation effort. The main threats faced by these Primatas is habitat loss and hunting, and the International Union for Conservation of Nature has rated the species as \"critically endangered\".",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg/320px-Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Thomas's Langur",
                Localizacao = "Indonesia",
                Detalhes = "Thomas's langur is a species of primate in the family Cercopithecidae. It is endemic to North Sumatra, Indonesia. Its natural habitat is subtropical or tropical dry forests. It is threatened by habitat loss. Its native names are reungkah in Acehnese and kedih in Alas.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Thomas%27s_langur_Presbytis_thomasi.jpg/142px-Thomas%27s_langur_Presbytis_thomasi.jpg"
            });

            Primatas.Add(new Animal
            {
                Nome = "Purple-faced Langur",
                Localizacao = "Sri Lanka",
                Detalhes = "The purple-faced langur, also known as the purple-faced leaf monkey, is a species of Old World monkey that is endemic to Sri Lanka. The animal is a long-tailed arboreal species, identified by a mostly brown appearance, dark face (with paler lower face) and a very shy nature. The species was once highly prevalent, found in suburban Colombo and the \"wet zone\" villages (areas with high temperatures and high humidity throughout the year, whilst rain deluges occur during the monsoon seasons), but rapid urbanization has led to a significant decrease in the population level of the Primatas.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Semnopithèque_blanchâtre_mâle.JPG/192px-Semnopithèque_blanchâtre_mâle.JPG"
            });

            Primatas.Add(new Animal
            {
                Nome = "Gelada",
                Localizacao = "Ethiopia",
                Detalhes = "The gelada, sometimes called the bleeding-heart monkey or the gelada baboon, is a species of Old World monkey found only in the Ethiopian Highlands, with large populations in the Semien Mountains. Theropithecus is derived from the Greek root words for \"beast-ape.\" Like its close relatives the baboons, it is largely terrestrial, spending much of its time foraging in grasslands.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Gelada-Pavian.jpg/320px-Gelada-Pavian.jpg"
            });

        }

    }
}

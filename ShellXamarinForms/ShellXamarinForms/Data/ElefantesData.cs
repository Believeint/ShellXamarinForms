﻿using ShellXamarinForms.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShellXamarinForms.Data
{
    public static class ElefantesData
    {
        public static IList<Animal> Elefantes { get; private set; }
        static ElefantesData()
        {
            Elefantes = new List<Animal>();

            Elefantes.Add(new Animal
            {
                Nome = "African Bush Elephant",
                Localizacao = "Africa",
                Detalhes = "The African bush elephant, also known as the African savanna elephant, is the larger of the two species of African Elefantes, and the largest living terrestrial animal. These Elefantes were previously regarded as the same species, but the African forest elephant has been reclassified as L. cyclotis.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/91/African_Elephant_%28Loxodonta_africana%29_bull_%2831100819046%29.jpg/320px-African_Elephant_%28Loxodonta_africana%29_bull_%2831100819046%29.jpg"
            });

            Elefantes.Add(new Animal
            {
                Nome = "African Forest Elephant",
                Localizacao = "Africa",
                Detalhes = "The African forest elephant is a forest-dwelling species of elephant found in the Congo Basin. It is the smallest of the three extant species of elephant, but still one of the largest living terrestrial animals. The African forest elephant and the African bush elephan  were considered to be one species until genetic studies indicated that they separated an estimated 2–7 million years ago. From an estimated population size of over 2 million prior to the colonization of Africa, the population in 2015 is estimated to be about 100,000 forest Elefantes, mostly living in the forests of Gabon. Due to a slower birth rate, the forest elephant takes longer to recover from poaching, which caused its population to fall by 65% from 2002 to 2014.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/6/6a/African_Forest_Elephant.jpg"
            });

            Elefantes.Add(new Animal
            {
                Nome = "Desert Elephant",
                Localizacao = "Africa",
                Detalhes = "Desert Elefantes, or desert-adapted Elefantes are not a distinct species of elephant but are African bush Elefantes that have made their homes in the Namib and Sahara deserts in Africa. It was believed at one time that they were a subspecies of the African bush elephant but this is no longer thought to be the case. Desert-dwelling Elefantes were once more widespread in Africa than they are now and are currently found only in Namibia and Mali. They tend to migrate from one waterhole to another following traditional routes which depend on the seasonal availability of food and water. They face pressure from poaching and from changes in land use by humans.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Desert_elephants_in_the_Huab_River.jpg/320px-Desert_elephants_in_the_Huab_River.jpg"
            });

            Elefantes.Add(new Animal
            {
                Nome = "Borneo Elephant",
                Localizacao = "Asia",
                Detalhes = "The Borneo elephant, also called the Borneo pygmy elephant, is a subspecies of Asian elephant that inhabits northeastern Borneo, in Indonesia and Malaysia. Its origin remains the subject of debate. A definitive subspecific classification as Elephas maximus borneensis awaits a detailed range-wide morphometric and genetic study. Since 1986, Elephas maximus has been listed as Endangered on the IUCN Red List as the population has declined by at least 50% over the last three generations, estimated to be 60–75 years. The species is pre-eminently threatened by habitat loss, degradation and fragmentation.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Elephant_%40_kabini.jpg/180px-Elephant_%40_kabini.jpg"
            });

            Elefantes.Add(new Animal
            {
                Nome = "Indian Elephant",
                Localizacao = "Asia",
                Detalhes = "The Indian elephant is one of three extant recognized subspecies of the Asian elephant and native to mainland Asia. Since 1986, the Asian elephant has been listed as Endangered on the IUCN Red List as the wild population has declined by at least 50% since the 1930s to 1940s, i.e. three elephant generations. The Asian elephant is threatened by habitat loss, degradation and fragmentation.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/Elephas_maximus_%28Bandipur%29.jpg/320px-Elephas_maximus_%28Bandipur%29.jpg"
            });

            Elefantes.Add(new Animal
            {
                Nome = "Sri Lankan Elephant",
                Localizacao = "Asia",
                Detalhes = "The Sri Lankan elephant is one of three recognized subspecies of the Asian elephant, and native to Sri Lanka. Since 1986, Elephas maximus has been listed as endangered by IUCN as the population has declined by at least 50% over the last three generations, estimated to be 60–75 years. The species is primarily threatened by habitat loss, degradation and fragmentation.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Srilankan_tuskelephant.jpg/213px-Srilankan_tuskelephant.jpg"
            });

            Elefantes.Add(new Animal
            {
                Nome = "Sumatran Elephant",
                Localizacao = "Asia",
                Detalhes = "The Sumatran elephant is one of three recognized subspecies of the Asian elephant, and native to the Indonesia island of Sumatra. In 2011, the Sumatran elephant has been classified as critically endangered by IUCN as the population has declined by at least 80% over the last three generations, estimated to be about 75 years. The subspecies is pre-eminently threatened by habitat loss, degradation and fragmentation, and poaching; over 69% of potential elephant habitat has been lost within the last 25 years. Much of the remaining forest cover is in blocks smaller than 250 km2 (97 sq mi), which are too small to contain viable elephant populations.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b6/Borobudur-Temple-Park_Elephant-cage-01.jpg/320px-Borobudur-Temple-Park_Elephant-cage-01.jpg"
            });

            Elefantes.Add(new Animal
            {
                Nome = "Pygmy Elephant",
                Localizacao = "Africa & Asia",
                Detalhes = "Pygmy Elefantes live in both Africa and Asia.The African pygmy elephant is currently considered to be a tiny morph of the African forest elephant. The Borneo elephant, a well-documented variety of elephant, is also calledmpygmy elephant. This elephant, inhabiting tropical rainforest in north Borneo (east Sabah and extreme north Kalimantan), was long thought to be identical to the Asian elephant and descended from a captive population. In 2003, DNA comparison revealed them to be probably a new subspecies.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/9/93/Borneo-elephant-PLoS_Biology.jpg"
            });

            Elefantes.Add(new Animal
            {
                Nome = "Mammoth",
                Localizacao = "Extinct",
                Detalhes = "A mammoth is any species of the extinct genus Mammuthus, one of the many genera that make up the order of trunked mammals called proboscideans. The various species of mammoth were commonly equipped with long, curved tusks and, in northern species, a covering of long hair. They lived from the Pliocene epoch (from around 5 million years ago) into the Holocene at about 4,000 years ago, and various species existed in Africa, Europe, Asia, and North America. They were members of the family Elephantidae, which also contains the two genera of modern Elefantes and their ancestors.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/62/Columbian_mammoth.JPG/320px-Columbian_mammoth.JPG"
            });

            Elefantes.Add(new Animal
            {
                Nome = "Mastodon",
                Localizacao = "Extinct",
                Detalhes = "Mastodons are any species of extinct proboscideans in the genus Mammut, distantly related to Elefantes, that inhabited North and Central America during the late Miocene or late Pliocene up to their extinction at the end of the Pleistocene 10,000 to 11,000 years ago. Mastodons lived in herds and were predominantly forest-dwelling animals that fed on a mixed diet obtained by browsing and grazing with a seasonal preference for browsing, similar to living Elefantes.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b0/Mammut_americanum.jpg/320px-Mammut_americanum.jpg"
            });

            Elefantes.Add(new Animal
            {
                Nome = "Dwarf Elephant",
                Localizacao = "Extinct",
                Detalhes = "Dwarf Elefantes are prehistoric members of the order Proboscidea which, through the process of allopatric speciation on islands, evolved much smaller body sizes (around 1.5-2.3 metres) in comparison with their immediate ancestors. Dwarf Elefantes are an example of insular dwarfism, the phenomenon whereby large terrestrial vertebrates (usually mammals) that colonize islands evolve dwarf forms, a phenomenon attributed to adaptation to resource-poor environments and selection for early maturation and reproduction. Some modern populations of Asian Elefantes have also undergone size reduction on islands to a lesser degree, resulting in populations of pygmy Elefantes.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/69/Elephas_skeleton.JPG/320px-Elephas_skeleton.JPG"
            });

            Elefantes.Add(new Animal
            {
                Nome = "Pygmy Mammoth",
                Localizacao = "Extinct",
                Detalhes = "The pygmy mammoth or Channel Islands mammoth is an extinct species of dwarf elephant descended from the Columbian mammoth of mainland North America. This species became extinct during the Quaternary extinction event in which many megafauna species became extinct due to changing conditions to which the species could not adapt. A case of island or insular dwarfism, from a recent analysis in 2010 it was determined that M. exilis was on average, 1.72 m (5.6 ft) tall at the shoulders and 760 kg (1,680 lb) in weight, in stark contrast to its 4.3 m (14 ft) tall, 9,070 kg (20,000 lb) ancestor. Another estimate gives a shoulder height of 2.02 m (6.6 ft) and a weight of 1,350 kg (2,980 lb).",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/f/f6/Mammuthus_exilis.jpg"
            });
        }
    }
}

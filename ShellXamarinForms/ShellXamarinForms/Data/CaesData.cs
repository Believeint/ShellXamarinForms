﻿using ShellXamarinForms.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShellXamarinForms.Data
{
    public static class CaesData
    {
        public static IList<Animal> Caes { get; private set; }
        static CaesData()
        {
            Caes = new List<Animal>();

            Caes.Add(new Animal
            {
                Nome = "Afghan Hound",
                Localizacao = "Afghanistan",
                Detalhes = "The Afghan Hound is a hound that is distinguished by its thick, fine, silky coat and its tail with a ring curl at the end. The breed is selectively bred for its unique features in the cold mountains of Afghanistan.  Other names for this breed are Kuchi Hound, Tāzī, Balkh Hound, Baluchi Hound, Barakzai Hound, Shalgar Hound, Kabul Hound, Galanday Hound or sometimes incorrectly African Hound.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/6/69/Afghane.jpg"
            });

            Caes.Add(new Animal
            {
                Nome = "Alpine Dachsbracke",
                Localizacao = "Austria",
                Detalhes = "The Alpine Dachsbracke is a small breed of dog of the scent hound type originating in Austria. The Alpine Dachsbracke was bred to track wounded deer as well as boar, hare, and fox. It is highly efficient at following a trail even after it has gone cold. The Alpine Dachsbracke is very sturdy, and Austria is said to be the country of origin.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Alpejski_gończy_krótkonożny_g99.jpg/320px-Alpejski_gończy_krótkonożny_g99.jpg"
            });

            Caes.Add(new Animal
            {
                Nome = "American Bulldog",
                Localizacao = "United States",
                Detalhes = "The American Bulldog is a breed of utility dog descended from the Old English Bulldog.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/5/5e/American_Bulldog_600.jpg"
            });

            Caes.Add(new Animal
            {
                Nome = "Bearded Collie",
                Localizacao = "Scotland",
                Detalhes = "The Bearded Collie, or Beardie, is a herding breed of dog once used primarily by Scottish shepherds, but now mostly a popular family companion. Bearded Collies have an average weight of 18–27 kilograms (40–60 lb). Males are around 51–56 centimetres (20–22 in) tall at the withers while females are around 51–53 centimetres (20–21 in) tall.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/9/9c/Bearded_Collie_600.jpg"
            });

            Caes.Add(new Animal
            {
                Nome = "Boston Terrier",
                Localizacao = "United States",
                Detalhes = "The Boston Terrier is a breed of dog originating in the United States of America. This American Gentleman was accepted in 1893 by the American Kennel Club as a non-sporting breed. Color and markings are important when distinguishing this breed to the AKC standard. They should be either black, brindle or seal with white markings. Bostons are small and compact with a short tail and erect ears. The AKC says they are highly intelligent and very easily trained. They are friendly and can be stubborn at times. The average life span of a Boston is around 11 to 13 years, though some can live well into their teens.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Boston-terrier-carlos-de.JPG/320px-Boston-terrier-carlos-de.JPG"
            });

            Caes.Add(new Animal
            {
                Nome = "Canadian Eskimo",
                Localizacao = "Canada",
                Detalhes = "The Canadian Eskimo Dog is an Arctic breed of working dog, which is often considered to be one of North America's oldest and rarest remaining purebred indigenous domestic canines. Other names include qimmiq or qimmit. They were brought from Siberia to North America by the Thule people 1,000 years ago, along with the Greenland Dog that is genetically identical.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/7/79/Spoonsced.jpg"
            });

            Caes.Add(new Animal
            {
                Nome = "Eurohound",
                Localizacao = "Scandinavia",
                Detalhes = "A Eurohound (also known as a Eurodog or Scandinavian hound) is a type of dog bred for sled dog racing. The Eurohound is typically crossbred from the Alaskan husky group and any of a number of pointing breeds.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/9/98/Eurohound.jpg"
            });

            Caes.Add(new Animal
            {
                Nome = "Irish Terrier",
                Localizacao = "Ireland",
                Detalhes = "The Irish Terrier is a dog breed from Ireland, one of many breeds of terrier. The Irish Terrier is considered one of the oldest terrier breeds. The Dublin dog show in 1873 was the first to provide a separate class for Irish Terriers. By the 1880s, Irish Terriers were the fourth most popular breed in Ireland and Britain.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/IrishTerrierSydenhamHillWoods.jpg/180px-IrishTerrierSydenhamHillWoods.jpg"
            });

            Caes.Add(new Animal
            {
                Nome = "Kerry Beagle",
                Localizacao = "Ireland",
                Detalhes = "The Kerry Beagle is one of the oldest Irish hound breeds, believed to be descendant from the Old Southern Hound or the Celtic Hounds. It is the only extant scent hound breed native to Ireland.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/7/75/Kerry_Beagle_from_1915.JPG"
            });

            Caes.Add(new Animal
            {
                Nome = "Norwegian Buhund",
                Localizacao = "Norway",
                Detalhes = "The Norwegian Buhund is a breed of dog of the spitz type. It is closely related to the Icelandic Sheepdog and the Jämthund. The Buhund is used as an all purpose farm and herding dog, as well as watch dog and a nanny dog.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/3/3b/Norwegian_Buhund_600.jpg"
            });

            Caes.Add(new Animal
            {
                Nome = "Patterdale Terrier",
                Localizacao = "England",
                Detalhes = "The Patterdale Terrier is a breed of dog descended from the Northern terrier breeds of the early 20th century. The origins of the breed can be traced back to the Lake District, specifically to Ullswater Hunt master Joe Bowman, an early Border Terrier breeder.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/05078045_Patterdale_Terrier.jpg/320px-05078045_Patterdale_Terrier.jpg"
            });

            Caes.Add(new Animal
            {
                Nome = "St. Bernard",
                Localizacao = "Italy, Switzerland",
                Detalhes = "The St. Bernard or St Bernard is a breed of very large working dog from the western Alps in Italy and Switzerland. They were originally bred for rescue by the hospice of the Great St Bernard Pass on the Italian-Swiss border. The hospice, built by and named after Italian monk Bernard of Menthon, acquired its first Caes between 1660 and 1670. The breed has become famous through tales of alpine rescues, as well as for its enormous size.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Hummel_Vedor_vd_Robandahoeve.jpg/320px-Hummel_Vedor_vd_Robandahoeve.jpg"
            });
        }

    }
}

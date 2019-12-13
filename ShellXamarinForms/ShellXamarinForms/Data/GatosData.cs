using ShellXamarinForms.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShellXamarinForms.Data
{
    public static class GatosData
    {
        public static IList<Animal> Gatos { get; private set; }
        static GatosData()
        {
            Gatos = new List<Animal>();

            Gatos.Add(new Animal
            {
                Nome = "Abyssinian",
                Localizacao = "Ethopia",
                Detalhes = "The Abyssinian is a breed of domestic short-haired cat with a distinctive tickedtabby coat, in which individual hairs are banded with different colors. The breed is named for Abyssinia (now called Ethiopia), where it is believed to have originated.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9b/Gustav_chocolate.jpg/168px-Gustav_chocolate.jpg"
            });

            Gatos.Add(new Animal
            {
                Nome = "Arabian Mau",
                Localizacao = "Arabian Peninsula",
                Detalhes = "The Arabian Mau is a formal breed of domestic cat, originated from the desert cat, a short-haired landrace native to the desert of the Arabian Peninsula. It lives there in the streets and has adapted very well to the extreme climate. The Arabian Mau is recognized as a formal breed by few fancier and breeder organization and cat registry, World Cat Federation (WCF) and Emirates Feline Federation (EFF). Based on one landrace, the Arabian Mau is a natural breed.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/d/d3/Bex_Arabian_Mau.jpg"
            });

            Gatos.Add(new Animal
            {
                Nome = "Bengal",
                Localizacao = "Asia",
                Detalhes = "The Bengal cat is a domesticated cat breed created from hybrids of domestic Gatos and the Asian leopard cat – the breed Nome comes from the taxonomic Nome. Back-crossing to domestic Gatos is then done with the goal of creating a healthy, and docile cat with wild-looking, high-contrast coat. Bengals have a wild appearance and may show spots, rosettes, arrowhead markings, or marbling.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Paintedcats_Red_Star_standing.jpg/187px-Paintedcats_Red_Star_standing.jpg"
            });

            Gatos.Add(new Animal
            {
                Nome = "Burmese",
                Localizacao = "Thailand",
                Detalhes = "The Burmese cat is a breed of domestic cat, originating in Thailand, believed to have its roots near the present Thai-Burma border and developed in the United States and Britain.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/0/04/Blissandlucky11.jpg"
            });

            Gatos.Add(new Animal
            {
                Nome = "Cyprus",
                Localizacao = "Cyprus",
                Detalhes = "Cyprus Gatos, also known as Cypriot Gatos, Saint Helen Gatos, and Saint Nicholas Gatos, are a landrace of domestic cat found across the island of Cyprus. A standardized breed is being developed from them; among cat fancier and breeder organizations, it is presently fully recognized by the World Cat Federation (WCF), with breeding regulated by the World Cat Congress (WCC), under the Nome Aphrodite's Giant; and provisionally by The International Cat Association (TICA) as the Aphrodite. All three organizations permit shorthaired and semi-longhaired versions and no out-crossing to other breeds.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/CyprusShorthair.jpg/320px-CyprusShorthair.jpg"
            });

            Gatos.Add(new Animal
            {
                Nome = "German Rex",
                Localizacao = "Germany",
                Detalhes = "The German Rex is a medium-sized breed with slender legs of a medium length. The head is round with well-developed cheeks and large, open ears. The eyes are of medium size in colours related to the coat colour. The coat is silky and short with a tendency to curl. The whiskers also curl, though less strongly than in the Cornish Rex. They may be nearly straight. All colours of coat, including white, are allowed. The body development is heavier than in the Cornish Rex - more like the European Shorthairs.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/c/c7/German_rex_harry_%28cropped%29.jpg"
            });

            Gatos.Add(new Animal
            {
                Nome = "Highlander",
                Localizacao = "United States",
                Detalhes = "The Highlander (also known as the Highlander Shorthair, and originally as the Highland Lynx), is an experimental breed of cat. The unique appearance of the Highlander comes from the deliberate cross between the Desert Lynx and the Jungle Curl breeds, also recently developed. The latter of these has some non-domestic ancestry from two Asian small cat species, the leopard cat and jungle cat, making the Highlander nominally a feline hybrid, though its foundation stock is mostly domestic cat.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Highlander-7.jpg/293px-Highlander-7.jpg"
            });

            Gatos.Add(new Animal
            {
                Nome = "Manx",
                Localizacao = "Isle of Man",
                Detalhes = "The Manx cat is a breed of domestic cat originating on the Isle of Man, with a naturally occurring mutation that shortens the tail. Many Manx have a small stub of a tail, but Manx Gatos are best known as being entirely tailless; this is the most distinguishing characteristic of the breed, along with elongated hind legs and a rounded head. Manx Gatos come in all coat colours and patterns, though all-white specimens are rare, and the coat range of the original stock was more limited. Long-haired variants are sometimes considered a separate breed, the Cymric. Manx are prized as skilled hunters, and thus have often been sought by farmers with rodent problems, and been a preferred ship's cat breed. They are said to be social, tame and active. An old local term for the Gatos on their home island is stubbin. Manx have been exhibited in cat shows since the 1800s, with the first known breed standard published in 1903.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/en/9/9b/Manx_cat_by_Karen_Weaver.jpg"
            });

            Gatos.Add(new Animal
            {
                Nome = "Peterbald",
                Localizacao = "Russia",
                Detalhes = "The Peterbald is a cat breed of Russian origin. It was created in St Petersburg in 1994 from an experimental breeding by Olga S. Mironova. They resemble Oriental Shorthairs with a hair-losing gene. The breed was accepted for Championship class competition in 2009.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Peterbald_male_Shango_by_Irina_Polunina.jpg"
            });

            Gatos.Add(new Animal
            {
                Nome = "Scottish Fold",
                Localizacao = "Scotland",
                Detalhes = "The Scottish Fold is a breed of domestic cat with a natural dominant-gene mutation that affects cartilage throughout the body, causing the ears to fold, bending forward and down towards the front of the head, which gives the cat what is often described as an owl-like appearance.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/Adult_Scottish_Fold.jpg/240px-Adult_Scottish_Fold.jpg"
            });

            Gatos.Add(new Animal
            {
                Nome = "Sphynx",
                Localizacao = "Europe",
                Detalhes = "The Sphynx cat is a breed of cat known for its lack of coat (fur). It was developed through selective breeding, starting in the 1960s. The skin should have the texture of chamois, as it has fine hairs, or they may be completely hairless. Whiskers may be present, either whole or broken, or may be totally absent. They also have a narrow, long head, and webbed feet. Their skin is the color that their fur would be, and all the usual cat markings (solid, point, van, tabby, tortie, etc.) may be found on the Sphynx cat's skin. Because they have no coat, they lose more body heat than coated Gatos. This makes them warm to the touch as well as heat-seeking.",
                UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Sphinx2_July_2006.jpg/180px-Sphinx2_July_2006.jpg"
            });
        }
    }
}

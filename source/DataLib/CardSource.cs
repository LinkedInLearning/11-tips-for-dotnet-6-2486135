using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLib {
  public class CardSource {
    private List<CollectableCard> _cards;
    public CardSource() {
      _cards = new List<CollectableCard>();
      CollectableCard card;
      card = new CollectableCard
      {
        Id = 101,
        CardFamily = CardFamily.Monsters,
        Name = "Mingle",
        Slogan = "Double Trouble",
        EyeCount = 2,
        CatalogPrice = 5.99M,
        BidPrice = 15.95M,
        ImageUri = "Monster-Mingle-card.png",
        Description = "Mingle excels at doing twice the work in half the time, with pinpoint accuracy.  These skills serve her well in her role as Senior Data Analyst for an international cloud computing company. She's also got a penchant for ballroom dance, line dancing, and pretty much any kind of activity that lets her groove to music.",
        PopularityIndex = 890,


        TeamName = TeamNames.BlueShadows,
      };
      card.Details.Add("Best Smile", "Yes");
      card.Details.Add("Antenna", "None");

      _cards.Add(card);

      // CardFamily not set
      card = new CollectableCard
      {
        Id = 102,
        Name = "Yodel",
        Slogan = "Yodelay Hee Hoo!",
        EyeCount = 2,
        CatalogPrice = 5.99M,
        BidPrice = 6.95M,
        ImageUri = "Monster-Yodel-card.png",
        Description = "Yodel grew up in a family of singers and loud talkers and could never get a word in edgewise. Then his vast talent for yodeling emerged. Now he performs to adoring fans throughout the world, and always has the loudest voice at the dinner table. Incidentally, he's also a loud proponent of net neutrality, and spends countless hours moderating an internet forum devoted solely to that subject.",
        PopularityIndex = 510,
        TeamName = TeamNames.ThunderHeads,
      };

      card.Details.Add("Spikes", "Not yet");
      card.Details.Add("Antenna", "yes");
      _cards.Add(card);
      card = new CollectableCard
      {
        Id = 103,
        CardFamily = CardFamily.Monsters,
        Name = "Squido",
        Slogan = "An Eye for Design",
        EyeCount = 2,
        CatalogPrice = 5.99M,
        BidPrice = 6.95M,
        ImageUri = "Monster-Squido-card.png",
        Description = "Squido's got his hands or rather tentacles, in everything. First and foremost, he's a web designer with an eye for visual aesthetics, but he's also rather keen on UX design and making sure what he creates translates optimally to the end user. In his off-hours he's an avid nature photographer and bowler.",
        PopularityIndex = 670,
        TeamName = TeamNames.SpookTones,

      };
      card.Details.Add("Best Smile", "Yes");
      card.Details.Add("Antenna", "None");
      _cards.Add(card);

      card = new CollectableCard
      {
        Id = 104,
        CardFamily = CardFamily.Monsters,
        Name = "Spook",
        Slogan = "Safe and Sound",
        EyeCount = 3,
        CatalogPrice = 5.99M,
        BidPrice = 23.95M,
        ImageUri = "Monster-Spook-card.png",
        Description = "Cracking code and battling hackers is Spook's forte. She holds a prominent position as Head of Cyber Security for the Department of Monster Defense, where she thwarts attacks on government computer systems as often as she blinks. When not at work, Spook delights in serving up a fright at haunted mansions and ghost walks.",
        PopularityIndex = 690,
        TeamName = TeamNames.BlueShadows,
      };

      card.Details.Add("Spikes", "Yes");
      card.Details.Add("Antenna", "No");
      _cards.Add(card);

      card = new CollectableCard
      {
        Id = 105,
        CardFamily = CardFamily.Monsters,
        Name = "Melville",
        Slogan = "Networking Guru",
        EyeCount = 2,
        CatalogPrice = 5.99M,
        BidPrice = 8.25M,
        ImageUri = "Monster-Melville-card.png",
        Description = "Setting up computer networks has always come easily to Melville. In his role as Senior Network Engineer for Landon Hotel, Melville builds complex blueprints for communication networks, a task that requires enormous attention to detail and patience. When not at work, Melville chooses less taxing mental activities, like hiking in the hills near his Silicon Valley home.",
        PopularityIndex = 470,
        TeamName = TeamNames.ThunderHeads,
      };

      card.Details.Add("Spikes", "Yes");
      card.Details.Add("Antenna", "No");
      _cards.Add(card);

      card = new CollectableCard
      {
        Id = 106,
        CardFamily = CardFamily.Monsters,
        Name = "Filo",
        Slogan = "Baker by Day, Techie by Night",
        EyeCount = 3,
        CatalogPrice = 5.99M,
        BidPrice = 13.95M,
        ImageUri = "Monster-Filo-card.png",
        Description = "Filo was named after the wonderful, buttery pastry crust that monsters adore. She’s a prominent baker and pastry chef in monster circles and is always exploring and sharing new dessert trends. In her off time, however, she's quite the techie and dabbles in web and mobile app development. She even built a custom cake ordering app for her pastry business.",
        PopularityIndex = 850,
        TeamName = TeamNames.BlueShadows,
      };
      card.Details.Add("Spikes", "No");
      card.Details.Add("Antenna", "No");
      _cards.Add(card);

      card = new CollectableCard
      {
        Id = 107,
        CardFamily = CardFamily.Monsters,
        Name = "Blade",
        Slogan = "Monster APPetite",
        EyeCount = 1,
        CatalogPrice = 5.99M,
        BidPrice = 42.50M,
        ImageUri = "Monster-Blade-card.png",
        Description = "Blade freelances as a mobile app developer and has built some of the most popular Android and iOS apps used in modern monster society, including the award-winning Monster APPetite, which tracks calorie consumption and activity for the health-conscious monster. In his spare time, he competes in national agility contests with his border collie Winston.",
        PopularityIndex = 820,

        TeamName = TeamNames.ThunderHeads,
      };

      card.Details.Add("Spikes", "Yes");
      card.Details.Add("Antenna", "No");
      _cards.Add(card);

      card = new CollectableCard
      {
        Id = 108,
        CardFamily = CardFamily.Monsters,
        Name = "Timber",
        Slogan = "Database Expert",
        EyeCount = 2,
        CatalogPrice = 5.99M,
        BidPrice = 11.95M,
        ImageUri = "Monster-Timber-card.png",
        Description = "A natural-born problem-solver, Timber's especially excited to solve complex business problems using databases. As a database administrator for Globe Bank International, he's able to flex his mental muscles using his certifications in Oracle, Microsoft SQL Server, and MySQL. When not behind the computer, Timber can often be found biking, surfing, or lounging around with a good detective novel",
        PopularityIndex = 220,
        TeamName = TeamNames.SpookTones,
      };

      card.Details.Add("Spikes", "No");
      card.Details.Add("Antenna", "No");
      _cards.Add(card);

      card = new CollectableCard
      {
        Id = 109,
        CardFamily = CardFamily.Monsters,
        Name = "Skedaddle",
        Slogan = "Game of Life",
        EyeCount = 1,
        CatalogPrice = 5.99M,
        BidPrice = 14.95M,
        ImageUri = "Monster-Skedaddle-card.png",
        Description = "When Skedaddle was a teenager, his parents couldn't keep him away from his Game Boy. In fact, they seriously worried that he might not find a suitable career.  Now as a prominent game developer for Red30 Tech, he's found his true calling and put his family's worries to rest. You probably could have guessed this, but in his spare time Skedaddle loves to pay computer games.",
        PopularityIndex = 720,

        TeamName = TeamNames.BlueShadows,
      };
      card.Details.Add("Spikes", "None");
      card.Details.Add("Antenna", "None");
      _cards.Add(card);
      card = new CollectableCard
      {
        Id = 110,
        CardFamily = CardFamily.Monsters,
        Name = "Smiley",
        Slogan = "Don’t Worry, Be Happy!",
        EyeCount = 1,
        CatalogPrice = 5.99M,
        BidPrice = 32.95M,
        ImageUri = "Monster-Smiley-card.png",
        Description = "With the bad rap they get from movies, monsters have it pretty tough. Perhaps no monster has done more to squash stereotypes than Smiley, who can take anyone’s frown and turn it upside down. That's why Smiley has a reputation as the best computer support specialist on her IT team, three years running.",
        PopularityIndex = 590,
        TeamName = TeamNames.ThunderHeads,
      };
      card.Details.Add("Spikes", "Yes");
      card.Details.Add("Antenna", "Yes");
      _cards.Add(card);

      card = new CollectableCard
      {
        Id = 111,
        CardFamily = CardFamily.Monsters,
        Name = "Frex",
        Slogan = "Born Leader",
        EyeCount = 4,
        CatalogPrice = 5.99M,
        BidPrice = 16.50M,
        ImageUri = "Monster-Frex-card.png",
        Description = "Frex has always had a knack for leadership, starting from his days of being a Monster Scout. After studying computer science in college, and working as an IT specialist at several large companies, he naturally followed the  management path.  Now, as an IT manager for a Fortune 500 company, he gets to put his technical know-how to work, while also leading a team of talented engineers. Frex's hobbies include golf, billiards, and community service.",
        PopularityIndex = 370,

        TeamName = TeamNames.SpookTones,
      };

      card.Details.Add("Spikes", "No");
      card.Details.Add("Antenna", "No");
      _cards.Add(card);

      card = new CollectableCard
      {
        Id = 112,
        CardFamily = CardFamily.Monsters,
        Name = "Drift",
        Slogan = "In the Clouds",
        EyeCount = 2,
        CatalogPrice = 5.99M,
        BidPrice = 17.95M,
        ImageUri = "Monster-Drift-card.png",
        Description = "After years of everyone saying her head was in the clouds, Drift found her calling as a software engineer developing a well-known cloud solution for the computing giant, Red30 Tech. After work, she prefers to unwind by catching wind in her sail and paragliding high in the sky.",
        PopularityIndex = 340,

        TeamName = TeamNames.BlueShadows,
      };

      // aliens
      card = new CollectableCard
      {
        Id = 201,
        CardFamily = CardFamily.Aliens,
        Name = "Violette",
        Slogan = "Planet: Amethystopia",
        EyeCount = 2,
        CatalogPrice = 5.99M,
        BidPrice = 8.95M,
        ImageUri = "Alien-Violette-md.png",
        Description = "Violette holds a doctorate degree in Planetary Behaviorism from Fouraluy University. She has been fascinated in researching the behavior of sentient beings as long as she can remember. She feels her experience in animal husbandry growing up on her family farm gave her a unique perspective in and appreciation for all life that drives and complements her current work as a behaviorist. She loves ballet, classic disco, and spending time with her 17 Earth chickens.",
        PopularityIndex = 188,

        TeamName = TeamNames.Helios,
      };

      card.Details.Add("Favorite Earth Food", "Plum Pudding");
      card.Details.Add("Locomotion", "Walking, jumping");
      card.Details.Add("Dream Job", "Principle Disco Dancer for the Amethystopia Ballet");
      _cards.Add(card);

      card = new CollectableCard
      {
        Id = 202,
        CardFamily = CardFamily.Aliens,
        Name = "Laverne",
        Slogan = "Planet: Isronch Major",
        EyeCount = 2,
        CatalogPrice = 5.99M,
        BidPrice = 22.95M,
        ImageUri = "Alien-Laverne-md.png",
        Description = "Laverne holds a degree in theoretical physics from Quantumnus University. Having interned for the great theoretical physicist, Bob, Laverne pursued a natural aptitude in understanding relationships among dissimilar measurable quantities to become the theoretical physics coordinator at Quantumnus U.",
        PopularityIndex = 391,

        TeamName = TeamNames.Farsiders,
      };

      card.Details.Add("Favorite Earth Food", "S'mores");
      card.Details.Add("Locomotion", "Swimming, walking");
      card.Details.Add("Dream Job", "Pilates Instructor");
      _cards.Add(card);

      card = new CollectableCard
      {
        Id = 203,
        CardFamily = CardFamily.Aliens,
        Name = "Tomolor",
        Slogan = "Planet: Isronch Major",
        EyeCount = 2,
        CatalogPrice = 4.99M,
        BidPrice = 17.95M,
        ImageUri = "Alien-Tomolor-md.png",
        Description = "As a professional computer systems analyst, Tomolor has made history in adapting systems for countless organizations, increasing their overall efficiency by an average of 65%. An active member of the <em>Beinghood of Bookery</em>, Tomolor has authored several children’s books that explain how to flourish in their respective areas of interest so that they can most efficiently metamorphose into a career they love.",
        PopularityIndex = 391,

        TeamName = TeamNames.SuperNovas,
      };

      card.Details.Add("Favorite Earth Food", "SBaked Potato");
      card.Details.Add("Locomotion", "Walking");
      card.Details.Add("Dream Job", "Children’s Book Author");
      _cards.Add(card);


      card = new CollectableCard
      {
        Id = 204,
        CardFamily = CardFamily.Aliens,
        Name = "Celestia Dristi",
        Slogan = "Planet: Krachonk",
        EyeCount = 1,
        CatalogPrice = 3.99M,
        BidPrice = 28.95M,
        ImageUri = "Alien-CelestiaDristi-md.png",
        Description = "As a mobility engineer, Celestia Dristi helps individuals and companies to improve personal and professional agility and growth in technology and systems. An expert in translating and implementing needs into functionality, Celestia Dristi has a unique proclivity for solving problems and helping to avoid future issues.",
        PopularityIndex = 674,

        TeamName = TeamNames.Helios,
      };

      card.Details.Add("Favorite Earth Food", "Ice cream cake");
      card.Details.Add("Locomotion", "Rolling");
      card.Details.Add("Dream Job", "Mime");
      _cards.Add(card);

      card = new CollectableCard
      {
        Id = 205,
        CardFamily = CardFamily.Aliens,
        Name = "Two",
        Slogan = "Planet: Strogarus",
        EyeCount = 2,
        CatalogPrice = 4.99M,
        BidPrice = 3.95M,
        ImageUri = "Alien-Two-md.png",
        Description = "With growing interest by organizations in expanding their business on multiple planets, Two finds that it is increasingly critical to focus on sustainability. As Two describes it, we can’t expect any business to be viable long-term if a planet and its beings aren’t well cared for. Currently stationed on Earth, Two enjoys collecting and studying lithium batteries.",
        PopularityIndex = 602,

        TeamName = TeamNames.Farsiders
      };

      card.Details.Add("Favorite Earth Food", "Scallions");
      card.Details.Add("Locomotion", "Ice skating, walking");
      card.Details.Add("Dream Job", "Professional Traveler");
      _cards.Add(card);

      card = new CollectableCard
      {
        Id = 206,
        CardFamily = CardFamily.Aliens,
        Name = "Narf the Fourth",
        Slogan = "Planet: Krachonk",
        EyeCount = 1,
        CatalogPrice = 4.99M,
        BidPrice = 16.95M,
        ImageUri = "Alien-Narf-the-fourth-md.png",
        Description = "Narf the Fourth (known to friends as ‘Norf’) oversees the manufacturing of astronomic spaceship accessories at Saucer & Rocket, Inc. Norf keeps an eye on all aspects of production quality, including managing several lower quality assurance specialists. Interests include jet-pack racing, bodybuilding, and volunteer baseball coach. Friends tell us that it’s not summer if you don't hear Norf yelling ”keep your eye on the ball!",
        PopularityIndex = 602,

        TeamName = TeamNames.SuperNovas
      };

      card.Details.Add("Favorite Earth Food", "Calzones");
      card.Details.Add("Locomotion", "Walking, jetpack");
      card.Details.Add("Dream Job", "Hand Model");
      _cards.Add(card);


      card = new CollectableCard
      {
        Id = 207,
        CardFamily = CardFamily.Aliens,
        Name = "Trisaphron",
        Slogan = "Planet: Hexapoda Minor",
        EyeCount = 3,
        CatalogPrice = 6.99M,
        BidPrice = 15.95M,
        ImageUri = "Alien-Trisaphron-md.png",
        Description = "Trisaphron earned a masters degree in practical operations from Omerania University after completing a bachelors of science in impractical mathematics. With a keen ability to watch and understand the nuances of cooperation among production robots, Trisaphron never hesitates to jump in and lend a hand or two or three to educate and improve procedures.",
        PopularityIndex = 106,

        TeamName = TeamNames.Helios,
      };

      card.Details.Add("Favorite Earth Food", "Tom ka gai");
      card.Details.Add("Locomotion", "Walking, running");
      card.Details.Add("Dream Job", "Mountain Climber");
      _cards.Add(card);


      card = new CollectableCard
      {
        Id = 208,
        CardFamily = CardFamily.Aliens,
        Name = "Ichabod",
        Slogan = "Planet: Krachonk",
        EyeCount = 3,
        CatalogPrice = 4.99M,
        BidPrice = 11.95M,
        ImageUri = "Alien-Ichabod-md.png",
        Description = "Operations supervisor Ichabod is unwavering in adherence to the perfection of order and function. Using inborn impassiveness to distracting influences, Ichabod has led several teams to operational distinction with the advantage of being able to successfully teach precise hoverboard maneuverability.",
        PopularityIndex = 429,

        TeamName = TeamNames.Farsiders
      };

      card.Details.Add("Favorite Earth Food", "Squeeze yogurt");
      card.Details.Add("Locomotion", "Hoverboard");
      card.Details.Add("Dream Job", "Senior Free-floater");
      _cards.Add(card);

      card = new CollectableCard
      {
        Id = 209,
        CardFamily = CardFamily.Aliens,
        Name = "Seymour",
        Slogan = "Planet: Pepinos IV",
        EyeCount = 2,
        CatalogPrice = 6.99M,
        BidPrice = 16.95M,
        ImageUri = "Alien-Seymour-md.png",
        Description = "\"If it isn't counted, it doesn't count!\"™ is the mantra Seymour originated and propagated in the colossal and growing industry of inventory control.Now trademarked as the slogan for Seymour's company, Totaling, it serves as reassurance of the company's mission and meaning for potential and current clients.Counting things is pretty much all Seymour does, other than recreational mountain climbing.",
        PopularityIndex = 333,

        TeamName = TeamNames.SuperNovas
      };

      card.Details.Add("Favorite Earth Food", "Dilly beans");
      card.Details.Add("Locomotion", "Rolling");
      card.Details.Add("Dream Job", "Hand model");
      _cards.Add(card);


      foreach (var currentCard in _cards)
      {
        currentCard.ShortDescription = GetShortText(currentCard.Description, 140) + "...";
      }


    }
    private string GetShortText(string candidate, int charCount) {
      if (candidate.Length > charCount)
      {
        return candidate.Substring(0, charCount);
      }
      else
      {
        return candidate;
      }


    }
    public List<CollectableCard> CollectibleCards
    {
      get
      {
        return _cards;
      }
    }
    public List<CollectableCard> CardsOrderedByName
    {
      get
      {
        return _cards.OrderBy(x => x.Name).ToList();
      }
    }
    public List<CollectableCard> MonsterCards
    {
      get
      {
        return _cards.Where(x => x.CardFamily == CardFamily.Monsters).OrderBy(x => x.Name).ToList();
      }
    }
    public List<CollectableCard> AlienCards
    {
      get
      {
        return _cards.Where(x => x.CardFamily == CardFamily.Aliens).OrderBy(x => x.Name).ToList();
      }
    }
  }
}

using Knjiznica.Database;
using Knjiznica.WebAPI.Properties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Database
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Knjiznicari
            var saltKnjiznicar = GenerateSalt();
            modelBuilder.Entity<Knjiznicar>().HasData(
                new Knjiznicar
                {
                    Id = 1,
                    Email = "desktop",
                    ImePrezime="admin test",
                    BrojTelefona="063123456",
                    DatumZaposljavanja=new DateTime(2014, 7, 5),
                    DatumOstavke=null,
                    PasswordSalt = saltKnjiznicar,
                    PasswordHash = GenerateHash(saltKnjiznicar, "test")
                }
                );

            #endregion

            #region Autori
            modelBuilder.Entity<Autor>().HasData(
                new Autor { Id=1, ImePrezime="Yeonmi Park"},
                new Autor { Id=2, ImePrezime="David Goggins"},
                new Autor { Id=3, ImePrezime="Sarah Andersen"},
                new Autor { Id=4, ImePrezime="Randall Munroe"},
                new Autor { Id=5, ImePrezime="Matt Haig"},
                new Autor { Id=6, ImePrezime="Taylor Jenkins Reid"},
                new Autor { Id=7, ImePrezime="J. K. Rowling"},
                new Autor { Id=8, ImePrezime="Dante Alighieri"},
                new Autor { Id=9, ImePrezime="J. R. R. Tolkien"},
                new Autor { Id=10, ImePrezime="Robert Audi"},
                new Autor { Id=11, ImePrezime="Stephen Mumford"},
                new Autor { Id=12, ImePrezime="Bret Easton Ellis"},
                new Autor { Id=13, ImePrezime="Mary Shelley"},
                new Autor { Id=14, ImePrezime="Stephen King"},
                new Autor { Id=15, ImePrezime="Fyodor Dostoyevsky"},
                new Autor { Id=16, ImePrezime="Mick Herron"},
                new Autor { Id=17, ImePrezime="Ian Shaw"},
                new Autor { Id=18, ImePrezime= "Yuval Noah Harari" },
                new Autor { Id=19, ImePrezime= "Jordan B. Peterson" },
                new Autor { Id=20, ImePrezime="Charles Duhigg"},
                new Autor { Id=21, ImePrezime="George Orwell"},
                new Autor { Id=22, ImePrezime="John Green"},
                new Autor { Id=23, ImePrezime="Bethany Clift"},
                new Autor { Id=24, ImePrezime="Chana Porter"},
                new Autor { Id=25, ImePrezime="Kobe Bryant"},
                new Autor { Id=26, ImePrezime="Patty Smith"},
                new Autor { Id=27, ImePrezime= "Jean Claude Gautrand" },
                new Autor { Id=28, ImePrezime= "Stephen Hawking" },
                new Autor { Id=29, ImePrezime= "Georgina Taylor" },
                new Autor { Id=30, ImePrezime= "Charles Darwin" }
                );
            #endregion

            #region Kategorije
            modelBuilder.Entity<Kategorija>().HasData(
                new Kategorija { Id=1,Naziv="Biography"},
                new Kategorija { Id = 2, Naziv = "Humor" },
                new Kategorija { Id = 3, Naziv = "Drama" },
                new Kategorija { Id = 4, Naziv = "Fantasy" },
                new Kategorija { Id = 5, Naziv = "Philosophy" },
                new Kategorija { Id = 6, Naziv = "Horror" },
                new Kategorija { Id = 7, Naziv = "Crime" },
                new Kategorija { Id = 8, Naziv = "History" },
                new Kategorija { Id = 9, Naziv = "Psychology" },
                new Kategorija { Id = 10, Naziv = "Sci-fi" },
                new Kategorija { Id = 11, Naziv = "Sport" },
                new Kategorija { Id = 12, Naziv = "Art" },
                new Kategorija { Id = 13, Naziv = "Science" }
                );
            #endregion

            #region Knjige
            modelBuilder.Entity<Knjiga>().HasData(
                new Knjiga { 
                    Id = 1, 
                    Naslov= "In Order to Live: A North Korean Girl's Journey to Freedom", 
                    AutorId=1, 
                    KategorijaId=1,
                    BrojDostupnihKopija=3, 
                    BrojKopija=3, 
                    BrojStranica=288, 
                    ISBN= "9780241973035" , 
                    Izdanje=1, 
                    DatumIzdavanja=new DateTime(2016,6,7), 
                    Slika=Resources.inorder,
                    Opis= "Yeonmi Park was not dreaming of freedom when she escaped from North Korea. She didn't even know what it meant to be free. All she knew was that she was running for her life, that if she and her family stayed behind they would die - from starvation, or disease, or even execution. \n This book is the story of Park's struggle to survive in the darkest, most repressive country on earth; her harrowing escape through China's underworld of smugglers and human traffickers; and then her escape from China across the Gobi desert to Mongolia, with only the stars to guide her way, and from there to South Korea and at last to freedom; and finally her emergence as a leading human rights activist -all before her 21st birthday."
                },
                new Knjiga
                {
                    Id = 2,
                    Naslov = "Can't Hurt Me: Master Your Mind and Defy the Odds",
                    AutorId = 2,
                    KategorijaId = 1,
                    BrojDostupnihKopija = 3,
                    BrojKopija = 3,
                    BrojStranica = 364,
                    ISBN = "9781544512273",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2018, 10, 11),
                    Slika = Resources.cant_hurt_me,
                    Opis= "For David Goggins, childhood was a nightmare -- poverty, prejudice, and physical abuse colored his days and haunted his nights. But through self-discipline, mental toughness, and hard work, Goggins transformed himself from a depressed, overweight young man with no future into a U.S. Armed Forces icon and one of the world's top endurance athletes. The only man in history to complete elite training as a Navy SEAL, Army Ranger, and Air Force Tactical Air Controller, he went on to set records in numerous endurance events, inspiring Outside magazine to name him 'The Fittest(Real) Man in America.'"
                },
                new Knjiga
                {
                    Id = 3,
                    Naslov = "Adulthood Is a Myth: A Sarah's Scribbles Collection",
                    AutorId = 3,
                    KategorijaId = 2,
                    BrojDostupnihKopija = 2,
                    BrojKopija = 2,
                    BrojStranica = 112,
                    ISBN = "9781449474195",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2016, 7, 4),
                    Slika = Resources.adulthood,
                    Opis = "These casually drawn, perfectly on-point comics by the hugely popular young Brooklyn-based artist Sarah Andersen are for the rest of us. They document the wasting of entire beautiful weekends on the internet, the unbearable agony of holding hands on the street with a gorgeous guy, and dreaming all day of getting home and back into pajamas. In other words, the horrors and awkwardnesses of young modern life. Oh and they are totally not autobiographical. At all."
                },
                new Knjiga
                {
                    Id = 4,
                    Naslov = "What If?: Serious Scientific Answers to Absurd Hypothetical Questions",
                    AutorId = 4,
                    KategorijaId = 2,
                    BrojDostupnihKopija = 2,
                    BrojKopija = 2,
                    BrojStranica = 320,
                    ISBN = "9781848549562",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2018, 10, 31),
                    Slika = Resources.what_if,
                    Opis = "Millions visit xkcd.com each week to read Randall Munroe's iconic webcomic. Fans ask him a lot of strange questions: How fast can you hit a speed bump, driving, and live? When (if ever) did the sun go down on the British Empire? When will Facebook contain more profiles of dead people than living? How many humans would a T Rex rampaging through New York need to eat a day? \n In pursuit of answers, Munroe runs computer simulations, pores over stacks of declassified military research memos, solves differential equations and consults nuclear reactor operators. His responses are masterpieces of clarity and hilarity, complemented by comics. They often predict the complete annihilation of humankind, or at least a really big explosion."
                },
                new Knjiga
                {
                    Id = 5,
                    Naslov = "The Midnight Library",
                    AutorId = 5,
                    KategorijaId = 3,
                    BrojDostupnihKopija = 3,
                    BrojKopija = 3,
                    BrojStranica = 304,
                    ISBN = "9781786892737",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2021, 2, 18),
                    Slika = Resources.midnight,
                    Opis = "Nora's life has been going from bad to worse. Then at the stroke of midnight on her last day on earth she finds herself transported to a library. There she is given the chance to undo her regrets and try out each of the other lives she might have lived. Which raises the ultimate question: with infinite choices, what is the best way to live?"
                },
                new Knjiga
                {
                    Id = 6,
                    Naslov = "The Seven Husbands of Evelyn Hugo",
                    AutorId = 6,
                    KategorijaId = 3,
                    BrojDostupnihKopija = 2,
                    BrojKopija = 2,
                    BrojStranica = 400,
                    ISBN = "9781982147662",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2020, 4, 2),
                    Slika = Resources.seveneleven,
                    Opis = "Monique is not exactly on top of the world. Her husband has left her, and her professional life is going nowhere. Regardless of why Evelyn has selected her to write her biography, Monique is determined to use this opportunity to jumpstart her career. \n Summoned to Evelyn's luxurious apartment, Monique listens in fascination as the actress tells her story. From making her way to Los Angeles in the 1950s to her decision to leave show business in the '80s, and, of course, the seven husbands along the way, Evelyn unspools a tale of ruthless ambition, unexpected friendship, and a great forbidden love.Monique begins to feel a very real connection to the legendary star, but as Evelyn's story near its conclusion, it becomes clear that her life intersects with Monique's own in tragic and irreversible ways."
                },
                new Knjiga
                {
                    Id = 7,
                    Naslov = "Harry Potter and the Philosopher's Stone",
                    AutorId = 7,
                    KategorijaId = 4,
                    BrojDostupnihKopija = 5,
                    BrojKopija = 5,
                    BrojStranica = 352,
                    ISBN = "9781408855652",
                    Izdanje = 5,
                    DatumIzdavanja = new DateTime(2014, 9, 1),
                    Slika = Resources.harrypotter,
                    Opis = "Escape to Hogwarts with the unmissable series that has sparked a lifelong reading journey for children and families all over the world. The magic starts here. Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive.Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle.Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. The magic starts here!"
                },
                new Knjiga
                {
                    Id = 8,
                    Naslov = "Inferno",
                    AutorId = 8,
                    KategorijaId = 4,
                    BrojDostupnihKopija = 10,
                    BrojKopija = 10,
                    BrojStranica = 150,
                    ISBN = "9781420952544",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2016, 2, 18),
                    Slika = Resources.inferno,
                    Opis = "One of the world's great literary masterpieces, the 'Divine Comedy' is at its heart an allegorical tale regarding man's search for divinity. The work is divided into three sections, 'Inferno', 'Purgatorio', and 'Paradiso', each containing thirty-three cantos. It is the narrative of a journey down through Hell, up the mountain of Purgatory, and through the revolving heavens into the presence of God. In this aspect it belongs to the two familiar medieval literary types of the Journey and the Vision, however Dante intended the work to be more than just simple allegory, layering the narrative with rich historical, moral, political, literal, and anagogical context."
                },
                new Knjiga
                {
                    Id = 9,
                    Naslov = "The Lord of the Rings",
                    AutorId = 9,
                    KategorijaId = 4,
                    BrojDostupnihKopija = 10,
                    BrojKopija = 10,
                    BrojStranica = 1178,
                    ISBN = "9780261103207",
                    Izdanje = 3,
                    DatumIzdavanja = new DateTime(2012, 8, 11),
                    Slika = Resources.lotr,
                    Opis = "The Lord of the Rings tells of the great quest undertaken by Frodo and the Fellowship of the Ring: Gandalf the Wizard; the hobbits Merry, Pippin, and Sam; Gimli the Dwarf; Legolas the Elf; Boromir of Gondor; and a tall, mysterious stranger called Strider."
                },
                new Knjiga
                {
                    Id = 10,
                    Naslov = "Epistemology : A Contemporary Introduction to the Theory of Knowledge",
                    AutorId = 10,
                    KategorijaId = 5,
                    BrojDostupnihKopija = 3,
                    BrojKopija = 3,
                    BrojStranica = 432,
                    ISBN = "9780415879231",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2010, 10, 1),
                    Slika = Resources.epistemology,
                    Opis= "Epistemology, or 'the theory of knowledge', is concerned with how we know what we know, what justifies us in believing what we believe, and what standards of evidence we should use in seeking truths about the world and human experience. This comprehensive introduction to the field of epistemology explains the concepts and theories central to understanding knowledge. Along with covering the traditional topics of the discipline in detail, Epistemology explores emerging areas of research. The third edition features new sections on such topics as the nature of intuition, the skeptical challenge of rational disagreement, and 'the value problem' - the range of questions concerning why knowledge and justified true belief have value beyond that of merely true belief. Updated and expanded, Epistemology remains a superb introduction to one of the most fundamental fields of philosophy."
                },
                new Knjiga
                {
                    Id = 11,
                    Naslov = "Metaphysics: A Very Short Introduction",
                    AutorId = 11,
                    KategorijaId = 5,
                    BrojDostupnihKopija = 2,
                    BrojKopija = 2,
                    BrojStranica = 128,
                    ISBN = "9780199657124",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2012, 9, 8),
                    Slika = Resources.metaphysics,
                    Opis = "Metaphysics is one of the traditional four main branches of philosophy, alongside ethics, logic and epistemology. It is also an area that continues to attract and hold a fascination for many people yet it is associated with being complex and abstract. For some it is associated with the mystical or religious. For others it is known through the metaphysical poets who talk of love and spirituality."
                },
                new Knjiga
                {
                    Id = 12,
                    Naslov = "American Psycho",
                    AutorId = 12,
                    KategorijaId = 6,
                    BrojDostupnihKopija = 2,
                    BrojKopija = 2,
                    BrojStranica = 416,
                    ISBN = "9780307278630",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2008, 6, 6),
                    Slika = Resources.american_psycho,
                    Opis= "In American Psycho, Bret Easton Ellis imaginatively explores the incomprehensible depths of madness and captures the insanity of violence in our time or any other. Patrick Bateman moves among the young and trendy in 1980s Manhattan. Young, handsome, and well educated, Bateman earns his fortune on Wall Street by day while spending his nights in ways we cannot begin to fathom. Expressing his true self through torture and murder, Bateman prefigures an apocalyptic horror that no society could bear to confront."
                },
                new Knjiga
                {
                    Id = 13,
                    Naslov = "Frankenstein",
                    AutorId = 13,
                    KategorijaId = 6,
                    BrojDostupnihKopija = 5,
                    BrojKopija = 5,
                    BrojStranica = 352,
                    ISBN = "9780141439471",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2003, 5, 6),
                    Slika = Resources.frankenstein,
                    Opis= "The world's most famous work of horror fiction: a devastating exploration of the limits of human creativity. Nominated as one of America's best-loved novels by PBS's The Great American Read Mary Shelley's timeless gothic novel presents the epic battle between man and monster at its greatest literary pitch. In trying to create life, the young student Victor Frankenstein unleashes forces beyond his control, setting into motion a long and tragic chain of events that brings Victor to the very brink of madness. How he tries to destroy his creation, as it destroys everything Victor loves, is a powerful story of love, friendship, scientific hubris, and horror."
                },
                new Knjiga
                {
                    Id = 14,
                    Naslov = "It",
                    AutorId = 14,
                    KategorijaId = 6,
                    BrojDostupnihKopija = 5,
                    BrojKopija = 5,
                    BrojStranica = 1184,
                    ISBN = "9781444707861",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2011, 7, 21),
                    Slika = Resources.it,
                    Opis= "It is a group of children who see - and feel - what makes Derry so horribly different. In the storm drains, in the sewers, IT lurks, taking on the shape of every nightmare, each one's deepest dread. Sometimes is appears as an evil clown named Pennywise and sometimes IT reaches up, seizing, tearing, killing... \n Time passes and the children grow up, move away and forget. Until they are called back, once more to confront IT as IT stirs and coils in the sullen depths of their memories, emerging again to make their past nightmares a terrible present reality."
                },
                new Knjiga
                {
                    Id = 15,
                    Naslov = "Crime and Punishment",
                    AutorId = 15,
                    KategorijaId = 7,
                    BrojDostupnihKopija = 10,
                    BrojKopija = 10,
                    BrojStranica = 528,
                    ISBN = "9781840224306",
                    Izdanje = 10,
                    DatumIzdavanja = new DateTime(2000, 5, 5),
                    Slika = Resources.crimepunishment,
                    Opis= "Crime and Punishment is one of the greatest and most readable novels ever written. From the beginning we are locked into the frenzied consciousness of Raskolnikov who, against his better instincts, is inexorably drawn to commit a brutal double murder. \n From that moment on, we share his conflicting feelings of self-loathing and pride, of contempt for and need of others, and of terrible despair and hope of redemption: and, in a remarkable transformation of the detective novel, we follow his agonised efforts to probe and confront both his own motives for, and the consequences of, his crime."
                },
                new Knjiga
                {
                    Id = 16,
                    Naslov = "Joe Country",
                    AutorId = 16,
                    KategorijaId = 7,
                    BrojDostupnihKopija = 5,
                    BrojKopija = 5,
                    BrojStranica = 352,
                    ISBN = "9781473657489",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2020, 2, 7),
                    Slika = Resources.joecountry,
                    Opis= "In Slough House memories are stirring, all of them bad. Catherine Standish is buying booze again, Louisa Guy is raking over the ashes of lost love, and new recruit Lech Wicinski, whose sins make him outcast even among the slow horses, is determined to discover who destroyed his career, even if he tears his life apart in the process."
                },
                new Knjiga
                {
                    Id = 17,
                    Naslov = "The Oxford History of Ancient Egypt",
                    AutorId = 17,
                    KategorijaId = 8,
                    BrojDostupnihKopija = 2,
                    BrojKopija = 2,
                    BrojStranica = 544,
                    ISBN = "9780192804587",
                    Izdanje = 2,
                    DatumIzdavanja = new DateTime(2004, 2, 19),
                    Slika = Resources.egypt,
                    Opis= "The Oxford History of Ancient Egypt uniquely covers 700,000 years of ancient Egypt from the stone age to the Roman conquest. The story of the ancient Egyptians, from their prehistoric origins to their conquest by the Persians, Greeks, and Romans makes for fascinating reading, with subjects ranging from the changing nature of life and death in the Nile valley to some of the earliest masterpieces of art, architecture, and literature in the ancient world."
                },
                new Knjiga
                {
                    Id = 18,
                    Naslov = "Sapiens: A Brief History of Humankind",
                    AutorId = 18,
                    KategorijaId = 8,
                    BrojDostupnihKopija = 5,
                    BrojKopija = 5,
                    BrojStranica = 512,
                    ISBN = "9780099590088",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2015, 5, 1),
                    Slika = Resources.sapiens,
                    Opis= "What makes us brilliant? What makes us deadly? What makes us Sapiens? Yuval Noah Harari challenges everything we know about being human in the perfect read for these unprecedented times. \n Earth is 4.5 billion years old. In just a fraction of that time, one species among countless others has conquered it: us. \n In this bold and provocative book, Yuval Noah Harari explores who we are, how we got here and where we're going."
                },
                new Knjiga
                {
                    Id = 19,
                    Naslov = "12 Rules for Life: An Antidote to Chaos",
                    AutorId = 19,
                    KategorijaId = 9,
                    BrojDostupnihKopija = 5,
                    BrojKopija = 5,
                    BrojStranica = 448,
                    ISBN = "9780141988511",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2019,  5, 7),
                    Slika = Resources._12rules,
                    Opis= "Jordan Peterson has helped millions of people, young and old, men and women, aim at a life of responsibility and meaning. Now he can help you. \n Drawing on his own work as a clinical psychologist and on lessons from humanity's oldest myths and stories, Peterson offers twelve profound and realistic principles to live by. After all, as he reminds us, we each have a vital role to play in the unfolding destiny of the world."
                },
                new Knjiga
                {
                    Id = 20,
                    Naslov = "The Power of Habit : Why We Do What We Do, and How to Change",
                    AutorId = 20,
                    KategorijaId = 9,
                    BrojDostupnihKopija = 5,
                    BrojKopija = 5,
                    BrojStranica = 400,
                    ISBN = "9781847946249",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2013, 12, 12),
                    Slika = Resources.habit,
                    Opis= "We can always change. In The Power of Habit, award-winning New York Times business reporter Charles Duhigg translates cutting-edge behavioural science into practical self-improvement action, distilling advanced neuroscience into fascinating narratives of transformation."
                },
                new Knjiga
                {
                    Id = 21,
                    Naslov="1984",
                    AutorId = 21,
                    KategorijaId = 10,
                    BrojDostupnihKopija = 10,
                    BrojKopija = 10,
                    BrojStranica = 336,
                    ISBN = "9780141036144",
                    Izdanje = 3,
                    DatumIzdavanja = new DateTime(2008, 10, 1),
                    Slika = Resources._1984,
                    Opis= "Winston Smith works for the Ministry of Truth in London, chief city of Airstrip One. Big Brother stares out from every poster, the Thought Police uncover every act of betrayal. When Winston finds love with Julia, he discovers that life does not have to be dull and deadening, and awakens to new possibilities. Despite the police helicopters that hover and circle overhead, Winston and Julia begin to question the Party; they are drawn towards conspiracy. Yet Big Brother will not tolerate dissent - even in the mind. For those with original thoughts they invented Room 101..."
                },
                new Knjiga
                {
                    Id = 22,
                    Naslov= "Last One at the Party",
                    AutorId = 23,
                    KategorijaId = 10,
                    BrojDostupnihKopija = 3,
                    BrojKopija = 3,
                    BrojStranica = 368,
                    ISBN = "9781529332124",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2021, 2, 4),
                    Slika = Resources.lastone,
                    Opis= "The human race has been wiped out by a virus called 6DM ('Six Days Maximum' - the longest you've got before your body destroys itself). But somehow, in London, one woman is still alive. A woman who has spent her whole life compromising what she wants, hiding how she feels and desperately trying to fit in. A woman who is entirely unprepared to face a future on her own. \n Now, with only an abandoned golden retriever for company, she must travel through burning cities, avoiding rotting corpses and ravenous rats on a final journey to discover if she really is the last surviving person on earth. And with no one else to live for, who will she become now that she's completely alone?"
                },
                new Knjiga
                {
                    Id = 23,
                    Naslov = "The Seep",
                    AutorId = 24,
                    KategorijaId = 10,
                    BrojDostupnihKopija = 2,
                    BrojKopija = 2,
                    BrojStranica = 272,
                    ISBN = "9781789095173",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2021, 2, 1),
                    Slika = Resources.seep,
                    Opis= "Trina Goldberg-Oneka is a fifty-year-old trans woman whose life is irreversibly altered in the wake of a gentle-but nonetheless world-changing-invasion by an alien entity called The Seep. Through The Seep, everything is connected. Capitalism falls, hierarchies and barriers are broken down; if something can be imagined, it is possible. \n Trina and her wife, Deeba, live blissfully under The Seep's utopian influence-until Deeba begins to imagine what it might be like to be reborn as a baby, which will give her the chance at an even better life. Using Seeptech to make this dream a reality, Deeba moves on to a new existence, leaving Trina devastated. \n Heartbroken and deep into an alcoholic binge, Trina follows a lost boy she encounters, embarking on an unexpected quest. In her attempt to save him from The Seep, she will confront not only one of its most avid devotees, but the terrifying void that Deeba has left behind. A strange new elegy of love and loss, The Seep explores grief, alienation, and the ache of moving on."
                },
                new Knjiga
                {
                    Id = 24,
                    Naslov = "The Mamba Mentality: How I Play",
                    AutorId = 25,
                    KategorijaId = 11,
                    BrojDostupnihKopija = 2,
                    BrojKopija = 2,
                    BrojStranica = 208,
                    ISBN = "9780374201234",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2020, 2, 27),
                    Slika = Resources.mamba,
                    Opis= "In the wake of his retirement from professional basketball, Kobe 'The Black Mamba' Bryant decided to share his vast knowledge and understanding of the game to take readers on an unprecedented journey to the core of the legendary 'Mamba mentality'. Citing an obligation and an opportunity to teach young players, hardcore fans, and devoted students of the game how to play it 'the right way,' The Mamba Mentality takes us inside the mind of one of the most intelligent, analytical, and creative basketball players ever."
                },
                new Knjiga
                {
                    Id = 25,
                    Naslov = "Just Kids",
                    AutorId = 26,
                    KategorijaId = 12,
                    BrojDostupnihKopija = 2,
                    BrojKopija = 2,
                    BrojStranica = 320,
                    ISBN = "9780747568766",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2012, 1, 4),
                    Slika = Resources.justkids,
                    Opis= "In 1967, a chance meeting between two young people led to a romance and a lifelong friendship that would carry each to international success never dreamed of. The backdrop is Brooklyn, Chelsea Hotel, Max's Kansas City, Scribner's Bookstore, Coney Island, Warhol's Factory and the whole city resplendent. Among their friends, literary lights, musicians and artists such as Harry Smith, Bobby Neuwirth, Allen Ginsberg, Sandy Daley, Sam Shepherd, William Burroughs, etc. It was a heightened time politically and culturally; the art and music worlds exploding and colliding. In the midst of all this two kids made a pact to always care for one another. Scrappy, romantic, committed to making art, they prodded and provided each other with faith and confidence during the hungry years--the days of cous-cous and lettuce soup. \n Just Kids begins as a love story and ends as an elegy. Beautifully written, this is a profound portrait of two young artists, often hungry, sated only by art and experience. And an unforgettable portrait of New York, her rich and poor, hustlers and hellions, those who made it and those whose memory lingers near."
                },
                new Knjiga
                {
                    Id = 26,
                    Naslov = "Paris. Portrait of a City",
                    AutorId = 27,
                    KategorijaId = 12,
                    BrojDostupnihKopija = 2,
                    BrojKopija = 2,
                    BrojStranica = 544,
                    ISBN = "9783836502931",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2021, 2, 19),
                    Slika = Resources.parisportrait,
                    Opis= "A city built on two millennia of history, Paris is entering the third century of its love story with photography.It was on the banks of the Seine that Niepce and Daguerre officially gave birth to this new art that has flourished ever since, developing a distinctive language and becoming a vital tool of knowledge.Paris: Portrait of a City leads us through what Goethe described as a 'universal city where every step upon a bridge or a square recalls a great past,where a fragment of history is unrolled at the corner of every street.' The history of Paris is recounted in photographs ranging from Daguerre's early incunabula to the most recent images-an almost complete record of over a century and a half of transformations and a vast panorama spanning more than 600 pages and 500 photographs. This book brings together the past and the present, the monumental and the everyday, objects and people. Images captured by the most illustrious photographers-Daguerre, Marville, Atget, Lartigue, Brassai, Kertesz, Ronis, Doisneau, Cartier-Bresson, and many more-but also by many unknown photographers, attempt to bottle just a little of that 'Parisian air,' something of that particular poetry given out by the stones and inhabitants of a constantly changing city that has inspired untold numbers of writers and artists over the ages."
                },
                new Knjiga
                {
                    Id = 27,
                    Naslov = "A Brief History Of Time : From Big Bang To Black Holes",
                    AutorId = 28,
                    KategorijaId = 13,
                    BrojDostupnihKopija = 5,
                    BrojKopija = 5,
                    BrojStranica = 272,
                    ISBN = "9780857501004",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2015, 1, 20),
                    Slika = Resources.briefhistory,
                    Opis= "Was there a beginning of time? Could time run backwards? Is the universe infinite or does it have boundaries? \n These are just some of the questions considered in the internationally acclaimed masterpiece by the world renowned physicist - generally considered to have been one of the world's greatest thinkers. It begins by reviewing the great theories of the cosmos from Newton to Einstein, before delving into the secrets which still lie at the heart of space and time, from the Big Bang to black holes, via spiral galaxies and strong theory. To this day A Brief History of Time remains a staple of the scientific canon, and its succinct and clear language continues to introduce millions to the universe and its wonders."
                },
                new Knjiga
                {
                    Id = 28,
                    Naslov = "On the Origin of Species : By Means of Natural Selection",
                    AutorId = 29,
                    KategorijaId = 13,
                    BrojDostupnihKopija = 5,
                    BrojKopija = 5,
                    BrojStranica = 336,
                    ISBN = "9780486450063",
                    Izdanje = 3,
                    DatumIzdavanja = new DateTime(2006, 10, 27),
                    Slika = Resources.origin,
                    Opis= "The Origin is one of the most important books ever published, and a knowledge of it should be a part of the intellectual equipment of every educated person. . . . The book will endure in future ages so long as a knowledge of science persists among mankind. -- Nature. \n It took Charles Darwin more than twenty years to publish this book, in part because he realized that it would ignite a firestorm of controversy. On the Origin of Species first appeared in 1859, and it remains a continuing source of conflict to this day. Even among those who reject its ideas, however, the work's impact is undeniable. In science, philosophy, and theology, this is a book that changed the world. In addition to its status as the focus of a dramatic turning point in scientific thought, On the Origin of Species stands as a remarkably readable study.Carefully reasoned and well - documented in its arguments, the work offers coherent views of natural selection, adaptation, the struggle for existence, survival of the fittest, and other concepts that form the foundation of modern evolutionary theory.This volume is a reprint of the critically acclaimed first edition."
                },
                new Knjiga
                {
                    Id = 29,
                    Naslov = "The Anthropocene Reviewed",
                    AutorId = 22,
                    KategorijaId = 13,
                    BrojDostupnihKopija = 3,
                    BrojKopija = 3,
                    BrojStranica = 304,
                    ISBN = "9781529109870",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2021, 5, 18),
                    Slika = Resources.anthropocene,
                    Opis= "The Anthropocene is the current geological age, in which human activity has profoundly shaped the planet and its biodiversity. In this remarkable symphony of essays adapted and expanded from his ground-breaking, critically acclaimed podcast, John Green reviews different facets of the human-centered planet - from the QWERTY keyboard and Halley's Comet to Penguins of Madagascar - on a five-star scale."
                },
                new Knjiga
                {
                    Id = 30,
                    Naslov = "Made for Each Other",
                    AutorId = 29,
                    KategorijaId = 12,
                    BrojDostupnihKopija = 2,
                    BrojKopija = 2,
                    BrojStranica = 64,
                    ISBN = "9781787414242",
                    Izdanje = 1,
                    DatumIzdavanja = new DateTime(2021, 1, 21),
                    Slika = Resources.madefor,
                    Opis= "In the natural world, it benefits to have a friend. Teamwork, or an unexpected partner, could make all the difference to survival - whether it's warding off predators, removing parasites or aiding reproduction. This beautifully illustrated title explores organisms that have learnt to adapt and co-exist in the wild. From the monarch butterfly that only exists on one type of plant, to the majestic bobtail squid that acquires its illuminating glow from bacteria that live on its skin, take a closer look at some of nature's most fascinating symbiotic relationships."
                }
            );
            #endregion

            #region Clanovi
            List<string> Salts = new List<string>(), Hashes = new List<string>();
            string salt = GenerateSalt();
            string hash = GenerateHash(salt, "test");

            Salts.Add(salt);
            Hashes.Add(hash);

            for (int i = 1; i < 10; i++)
            {
                salt = GenerateSalt();
                hash = GenerateHash(salt, "password123" + i);
                Salts.Add(salt);
                Hashes.Add(hash);
            }

            modelBuilder.Entity<Clan>().HasData(
                new Clan {
                    Id = 1, 
                    Email="mobile", 
                    ImePrezime="mobile test",
                    BrojIskaznice=1,
                    DatumUclanjivanja=new DateTime(2020, 8,7,9,30,20),
                    PasswordSalt=Salts[0],
                    PasswordHash= Hashes[0],
                    Status="Aktivan"
                },
                new Clan
                {
                    Id = 2,
                    Email = "marin.maric@edu.fit.ba",
                    ImePrezime = "Marin Marić",
                    BrojIskaznice = 2,
                    DatumUclanjivanja = new DateTime(2020, 3, 8, 9, 31, 0),
                    PasswordSalt = Salts[1],
                    PasswordHash = Hashes[1],
                    Status = "Aktivan"
                },
                new Clan
                {
                    Id = 3,
                    Email = "johndoe@gmail.com",
                    ImePrezime = "John Doe",
                    BrojIskaznice = 3,
                    DatumUclanjivanja = new DateTime(2020, 3, 7, 9, 31, 30),
                    PasswordSalt = Salts[2],
                    PasswordHash = Hashes[2],
                    Status = "Aktivan"
                },
                new Clan
                {
                    Id = 4,
                    Email = "marysue@hotmail.com",
                    ImePrezime = "Mary Sue",
                    BrojIskaznice = 4,
                    DatumUclanjivanja = new DateTime(2020, 3, 7, 9, 32, 0),
                    PasswordSalt = Salts[3],
                    PasswordHash = Hashes[3],
                    Status = "Aktivan"
                }, 
                new Clan
                {
                    Id = 5,
                    Email = "patrickmann@outlook.com",
                    ImePrezime = "Patrick Mann",
                    BrojIskaznice = 5,
                    DatumUclanjivanja = new DateTime(2020, 3, 7, 10, 32,0),
                    PasswordSalt = Salts[4],
                    PasswordHash = Hashes[4],
                    Status = "Aktivan"
                },
                new Clan
                {
                    Id = 6,
                    Email = "jakemanson@gmail.com",
                    ImePrezime = "Jake Manson",
                    BrojIskaznice = 6,
                    DatumUclanjivanja = new DateTime(2020, 3, 7, 10, 32, 0),
                    PasswordSalt = Salts[5],
                    PasswordHash = Hashes[5],
                    Status = "Aktivan"
                },
                new Clan
                {
                    Id = 7,
                    Email = "petermill@gmail.com",
                    ImePrezime = "Peter Mill",
                    BrojIskaznice = 7,
                    DatumUclanjivanja = new DateTime(2020, 3, 7, 10, 32, 0),
                    PasswordSalt = Salts[6],
                    PasswordHash = Hashes[6],
                    Status = "Aktivan"
                },
                new Clan
                {
                    Id = 8,
                    Email = "petermill@gmail.com",
                    ImePrezime = "Peter Mill",
                    BrojIskaznice = 8,
                    DatumUclanjivanja = new DateTime(2020, 3, 9, 10, 32, 15),
                    PasswordSalt = Salts[7],
                    PasswordHash = Hashes[7],
                    Status = "Aktivan"
                },
                new Clan
                {
                    Id = 9,
                    Email = "williamcraig@gmail.com",
                    ImePrezime = "William Craig",
                    BrojIskaznice = 9,
                    DatumUclanjivanja = new DateTime(2020, 3, 10, 10, 32, 15),
                    PasswordSalt = Salts[8],
                    PasswordHash = Hashes[8],
                    Status = "Aktivan"
                },
                new Clan
                {
                    Id = 10,
                    Email = "markwilliams@gmail.com",
                    ImePrezime = "Mark Williams",
                    BrojIskaznice = 10,
                    DatumUclanjivanja = new DateTime(2020, 3, 10, 10, 32, 15),
                    PasswordSalt = Salts[9],
                    PasswordHash = Hashes[9],
                    Status = "Aktivan"
                }
                );
            #endregion

            #region Kopije
            modelBuilder.Entity<Kopija>().HasData(
                new Kopija
                {
                    Id=1,
                    BrojKopije=1, 
                    KnjigaId=1,
                    TrenutniVlasnikId=1,
                    Zauzeta=0
                },
                new Kopija
                {
                    Id = 2,
                    BrojKopije = 2,
                    KnjigaId = 1,
                    TrenutniVlasnikId = 2,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 3,
                    BrojKopije = 3,
                    KnjigaId = 1,
                    TrenutniVlasnikId = 3,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 4,
                    BrojKopije = 1,
                    KnjigaId = 2,
                    TrenutniVlasnikId = 4,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 5,
                    BrojKopije = 2,
                    KnjigaId = 2,
                    TrenutniVlasnikId = 5,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 6,
                    BrojKopije = 3,
                    KnjigaId = 2,
                    TrenutniVlasnikId = 6,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 7,
                    BrojKopije = 1,
                    KnjigaId = 3,
                    TrenutniVlasnikId = 7,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 8,
                    BrojKopije = 2,
                    KnjigaId = 3,
                    TrenutniVlasnikId = 8,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 9,
                    BrojKopije = 1,
                    KnjigaId = 4,
                    TrenutniVlasnikId = 9,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 10,
                    BrojKopije = 2,
                    KnjigaId = 4,
                    TrenutniVlasnikId = 10,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 11,
                    BrojKopije = 1,
                    KnjigaId = 5,
                    TrenutniVlasnikId = 1,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 12,
                    BrojKopije = 2,
                    KnjigaId = 5,
                    TrenutniVlasnikId = 2,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 13,
                    BrojKopije = 3,
                    KnjigaId = 5,
                    TrenutniVlasnikId = 3,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 14,
                    BrojKopije = 1,
                    KnjigaId = 6,
                    TrenutniVlasnikId = 4,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 15,
                    BrojKopije = 2,
                    KnjigaId = 6,
                    TrenutniVlasnikId = 5,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 16,
                    BrojKopije = 1,
                    KnjigaId = 7,
                    TrenutniVlasnikId = 6,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 17,
                    BrojKopije = 2,
                    KnjigaId = 7,
                    TrenutniVlasnikId = 7,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 18,
                    BrojKopije = 3,
                    KnjigaId = 7,
                    TrenutniVlasnikId = 8,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 19,
                    BrojKopije = 4,
                    KnjigaId = 7,
                    TrenutniVlasnikId = 9,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 20,
                    BrojKopije = 5,
                    KnjigaId = 7,
                    TrenutniVlasnikId = 10,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 21,
                    BrojKopije = 1,
                    KnjigaId = 8,
                    TrenutniVlasnikId = 1,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 22,
                    BrojKopije = 2,
                    KnjigaId = 8,
                    TrenutniVlasnikId = 2,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 23,
                    BrojKopije = 3,
                    KnjigaId = 8,
                    TrenutniVlasnikId = 3,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 24,
                    BrojKopije = 4,
                    KnjigaId = 8,
                    TrenutniVlasnikId = 4,
                    Zauzeta = 0
                }, 
                new Kopija
                {
                    Id = 25,
                    BrojKopije = 5,
                    KnjigaId = 8,
                    TrenutniVlasnikId = 5,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 26,
                    BrojKopije = 6,
                    KnjigaId = 8,
                    TrenutniVlasnikId = 6,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 27,
                    BrojKopije = 7,
                    KnjigaId = 8,
                    TrenutniVlasnikId = 7,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 28,
                    BrojKopije = 8,
                    KnjigaId = 8,
                    TrenutniVlasnikId = 8,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 29,
                    BrojKopije = 9,
                    KnjigaId = 8,
                    TrenutniVlasnikId = 9,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 30,
                    BrojKopije = 10,
                    KnjigaId = 8,
                    TrenutniVlasnikId = 10,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 31,
                    BrojKopije = 1,
                    KnjigaId = 9,
                    TrenutniVlasnikId = 1,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 32,
                    BrojKopije = 2,
                    KnjigaId = 9,
                    TrenutniVlasnikId = 2,
                    Zauzeta = 0
                }, 
                new Kopija
                {
                    Id = 33,
                    BrojKopije = 3,
                    KnjigaId = 9,
                    TrenutniVlasnikId = 3,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 34,
                    BrojKopije = 4,
                    KnjigaId = 9,
                    TrenutniVlasnikId = 4,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 35,
                    BrojKopije = 5,
                    KnjigaId = 9,
                    TrenutniVlasnikId = 5,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 36,
                    BrojKopije = 6,
                    KnjigaId = 9,
                    TrenutniVlasnikId = 6,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 37,
                    BrojKopije = 7,
                    KnjigaId = 9,
                    TrenutniVlasnikId = 7,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 38,
                    BrojKopije = 8,
                    KnjigaId = 9,
                    TrenutniVlasnikId = 8,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 39,
                    BrojKopije = 9,
                    KnjigaId = 9,
                    TrenutniVlasnikId = 9,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 40,
                    BrojKopije = 10,
                    KnjigaId = 9,
                    TrenutniVlasnikId = 10,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 41,
                    BrojKopije = 1,
                    KnjigaId = 10,
                    TrenutniVlasnikId = 1,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 42,
                    BrojKopije = 2,
                    KnjigaId = 10,
                    TrenutniVlasnikId = 2,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 43,
                    BrojKopije = 3,
                    KnjigaId = 10,
                    TrenutniVlasnikId = 3,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 44,
                    BrojKopije = 1,
                    KnjigaId = 11,
                    TrenutniVlasnikId = 4,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 45,
                    BrojKopije = 2,
                    KnjigaId = 11,
                    TrenutniVlasnikId = 5,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 46,
                    BrojKopije = 1,
                    KnjigaId = 12,
                    TrenutniVlasnikId = 6,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 47,
                    BrojKopije = 2,
                    KnjigaId = 12,
                    TrenutniVlasnikId = 7,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 48,
                    BrojKopije = 1,
                    KnjigaId = 13,
                    TrenutniVlasnikId = 8,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 49,
                    BrojKopije = 2,
                    KnjigaId = 13,
                    TrenutniVlasnikId = 9,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 50,
                    BrojKopije = 3,
                    KnjigaId = 13,
                    TrenutniVlasnikId = 10,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 51,
                    BrojKopije = 4,
                    KnjigaId = 13,
                    TrenutniVlasnikId = 1,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 52,
                    BrojKopije = 5,
                    KnjigaId = 13,
                    TrenutniVlasnikId = 2,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 53,
                    BrojKopije = 1,
                    KnjigaId = 14,
                    TrenutniVlasnikId = 3,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 54,
                    BrojKopije = 2,
                    KnjigaId = 14,
                    TrenutniVlasnikId = 4,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 55,
                    BrojKopije = 3,
                    KnjigaId = 14,
                    TrenutniVlasnikId = 5,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 56,
                    BrojKopije = 4,
                    KnjigaId = 14,
                    TrenutniVlasnikId = 6,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 57,
                    BrojKopije = 5,
                    KnjigaId = 14,
                    TrenutniVlasnikId = 7,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 58,
                    BrojKopije = 1,
                    KnjigaId = 15,
                    TrenutniVlasnikId = 8,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 59,
                    BrojKopije = 2,
                    KnjigaId = 15,
                    TrenutniVlasnikId = 9,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 60,
                    BrojKopije = 3,
                    KnjigaId = 15,
                    TrenutniVlasnikId = 10,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 61,
                    BrojKopije = 4,
                    KnjigaId = 15,
                    TrenutniVlasnikId = 1,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 62,
                    BrojKopije = 5,
                    KnjigaId = 15,
                    TrenutniVlasnikId = 2,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 63,
                    BrojKopije = 6,
                    KnjigaId = 15,
                    TrenutniVlasnikId = 3,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 64,
                    BrojKopije = 7,
                    KnjigaId = 15,
                    TrenutniVlasnikId = 4,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 65,
                    BrojKopije = 8,
                    KnjigaId = 15,
                    TrenutniVlasnikId = 5,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 66,
                    BrojKopije = 9,
                    KnjigaId = 15,
                    TrenutniVlasnikId = 6,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 67,
                    BrojKopije = 10,
                    KnjigaId = 15,
                    TrenutniVlasnikId = 7,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 68,
                    BrojKopije = 1,
                    KnjigaId = 16,
                    TrenutniVlasnikId = 8,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 69,
                    BrojKopije = 2,
                    KnjigaId = 16,
                    TrenutniVlasnikId = 9,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 70,
                    BrojKopije = 3,
                    KnjigaId = 16,
                    TrenutniVlasnikId = 10,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 71,
                    BrojKopije = 4,
                    KnjigaId = 16,
                    TrenutniVlasnikId = 1,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 72,
                    BrojKopije = 5,
                    KnjigaId = 16,
                    TrenutniVlasnikId = 2,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 73,
                    BrojKopije = 1,
                    KnjigaId = 17,
                    TrenutniVlasnikId = 3,
                    Zauzeta = 0
                }, 
                new Kopija
                {
                    Id = 74,
                    BrojKopije = 2,
                    KnjigaId = 17,
                    TrenutniVlasnikId = 4,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 75,
                    BrojKopije = 1,
                    KnjigaId = 18,
                    TrenutniVlasnikId = 5,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 76,
                    BrojKopije = 2,
                    KnjigaId = 18,
                    TrenutniVlasnikId = 6,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 77,
                    BrojKopije = 3,
                    KnjigaId = 18,
                    TrenutniVlasnikId = 7,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 78,
                    BrojKopije = 4,
                    KnjigaId = 18,
                    TrenutniVlasnikId = 8,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 79,
                    BrojKopije = 5,
                    KnjigaId = 18,
                    TrenutniVlasnikId = 9,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 80,
                    BrojKopije = 1,
                    KnjigaId = 19,
                    TrenutniVlasnikId = 10,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 81,
                    BrojKopije = 2,
                    KnjigaId = 19,
                    TrenutniVlasnikId = 1,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 82,
                    BrojKopije = 3,
                    KnjigaId = 19,
                    TrenutniVlasnikId = 2,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 83,
                    BrojKopije = 4,
                    KnjigaId = 19,
                    TrenutniVlasnikId = 3,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 84,
                    BrojKopije = 5,
                    KnjigaId = 19,
                    TrenutniVlasnikId = 4,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 85,
                    BrojKopije = 1,
                    KnjigaId = 20,
                    TrenutniVlasnikId = 5,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 86,
                    BrojKopije = 2,
                    KnjigaId = 20,
                    TrenutniVlasnikId = 6,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 87,
                    BrojKopije = 3,
                    KnjigaId = 20,
                    TrenutniVlasnikId = 7,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 88,
                    BrojKopije = 4,
                    KnjigaId = 20,
                    TrenutniVlasnikId = 8,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 89,
                    BrojKopije = 5,
                    KnjigaId = 20,
                    TrenutniVlasnikId = 9,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 90,
                    BrojKopije = 1,
                    KnjigaId = 21,
                    TrenutniVlasnikId = 10,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 91,
                    BrojKopije = 2,
                    KnjigaId = 21,
                    TrenutniVlasnikId = 1,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 92,
                    BrojKopije = 3,
                    KnjigaId = 21,
                    TrenutniVlasnikId = 2,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 93,
                    BrojKopije = 4,
                    KnjigaId = 21,
                    TrenutniVlasnikId = 3,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 94,
                    BrojKopije = 5,
                    KnjigaId = 21,
                    TrenutniVlasnikId = 4,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 95,
                    BrojKopije = 6,
                    KnjigaId = 21,
                    TrenutniVlasnikId = 5,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 96,
                    BrojKopije = 7,
                    KnjigaId = 21,
                    TrenutniVlasnikId = 6,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 97,
                    BrojKopije = 8,
                    KnjigaId = 21,
                    TrenutniVlasnikId = 7,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 98,
                    BrojKopije = 9,
                    KnjigaId = 21,
                    TrenutniVlasnikId = 8,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 99,
                    BrojKopije = 10,
                    KnjigaId = 21,
                    TrenutniVlasnikId = 9,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 100,
                    BrojKopije = 1,
                    KnjigaId = 22,
                    TrenutniVlasnikId = 10,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 101,
                    BrojKopije = 2,
                    KnjigaId = 22,
                    TrenutniVlasnikId = 1,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 102,
                    BrojKopije = 3,
                    KnjigaId = 22,
                    TrenutniVlasnikId = 2,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 103,
                    BrojKopije = 1,
                    KnjigaId = 23,
                    TrenutniVlasnikId = 3,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 104,
                    BrojKopije = 2,
                    KnjigaId = 23,
                    TrenutniVlasnikId = 4,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 105,
                    BrojKopije = 1,
                    KnjigaId = 24,
                    TrenutniVlasnikId = 5,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 106,
                    BrojKopije = 2,
                    KnjigaId = 24,
                    TrenutniVlasnikId = 6,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 107,
                    BrojKopije = 1,
                    KnjigaId = 25,
                    TrenutniVlasnikId = 7,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 108,
                    BrojKopije = 2,
                    KnjigaId = 25,
                    TrenutniVlasnikId = 8,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 109,
                    BrojKopije = 1,
                    KnjigaId = 26,
                    TrenutniVlasnikId = 9,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 110,
                    BrojKopije = 2,
                    KnjigaId = 26,
                    TrenutniVlasnikId = 10,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 111,
                    BrojKopije = 1,
                    KnjigaId = 27,
                    TrenutniVlasnikId = 1,
                    Zauzeta = 0
                }, 
                new Kopija
                {
                    Id = 112,
                    BrojKopije = 2,
                    KnjigaId = 27,
                    TrenutniVlasnikId = 2,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 113,
                    BrojKopije = 3,
                    KnjigaId = 27,
                    TrenutniVlasnikId = 3,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 114,
                    BrojKopije = 4,
                    KnjigaId = 27,
                    TrenutniVlasnikId = 4,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 115,
                    BrojKopije = 5,
                    KnjigaId = 27,
                    TrenutniVlasnikId = 5,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 116,
                    BrojKopije = 1,
                    KnjigaId = 28,
                    TrenutniVlasnikId = 6,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 117,
                    BrojKopije = 2,
                    KnjigaId = 28,
                    TrenutniVlasnikId = 7,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 118,
                    BrojKopije = 3,
                    KnjigaId = 28,
                    TrenutniVlasnikId = 8,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 119,
                    BrojKopije = 4,
                    KnjigaId = 28,
                    TrenutniVlasnikId = 9,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 120,
                    BrojKopije = 5,
                    KnjigaId = 28,
                    TrenutniVlasnikId = 10,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 121,
                    BrojKopije = 1,
                    KnjigaId = 29,
                    TrenutniVlasnikId = 1,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 122,
                    BrojKopije = 2,
                    KnjigaId = 29,
                    TrenutniVlasnikId = 2,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 123,
                    BrojKopije = 3,
                    KnjigaId = 29,
                    TrenutniVlasnikId = 3,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 124,
                    BrojKopije = 1,
                    KnjigaId = 30,
                    TrenutniVlasnikId = 4,
                    Zauzeta = 0
                },
                new Kopija
                {
                    Id = 125,
                    BrojKopije = 2,
                    KnjigaId = 30,
                    TrenutniVlasnikId = 5,
                    Zauzeta = 0
                }
                );
            #endregion

            #region StatusRezervacije
            modelBuilder.Entity<StatusRezervacije>().HasData(
                new StatusRezervacije
                {
                    Id = 1,
                    Status = "Aktivna"
                },
                new StatusRezervacije
                {
                    Id = 2,
                    Status = "Prekinuta"
                },
                new StatusRezervacije
                {
                    Id = 3,
                    Status = "Dovršena"
                });
            #endregion

            #region Rezervacije
            modelBuilder.Entity<Rezervacija>().HasData(
                new Rezervacija
                {
                    Id=1,
                    StatusId=3,
                    KnjigaId=1,
                    ClanId=1,
                    DatumRezervacije=new DateTime(2021,1,1,1, 20,30),
                    DatumIsteka=new DateTime(2021, 1, 6, 1, 20,30)
                },
                new Rezervacija
                {
                    Id = 2,
                    StatusId = 3,
                    KnjigaId = 1,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2021, 1, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 1, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 3,
                    StatusId = 3,
                    KnjigaId = 1,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2021, 3, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 132,
                    StatusId = 2,
                    KnjigaId = 1,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2021, 3, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 4,
                    StatusId = 3,
                    KnjigaId = 2,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2021, 2, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 5,
                    StatusId = 3,
                    KnjigaId = 2,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2021, 2, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 6,
                    StatusId = 3,
                    KnjigaId = 2,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2021, 4, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 4, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 7,
                    StatusId = 3,
                    KnjigaId = 3,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2021, 4, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 4, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 8,
                    StatusId = 3,
                    KnjigaId = 3,
                    ClanId = 8,
                    DatumRezervacije = new DateTime(2021, 5, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 9,
                    StatusId = 3,
                    KnjigaId = 4,
                    ClanId = 9,
                    DatumRezervacije = new DateTime(2021, 5, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 10,
                    StatusId = 3,
                    KnjigaId = 4,
                    ClanId = 10,
                    DatumRezervacije = new DateTime(2021, 7, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 7, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 11,
                    StatusId = 3,
                    KnjigaId = 5,
                    ClanId = 1,
                    DatumRezervacije = new DateTime(2021, 7, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 7, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 12,
                    StatusId = 3,
                    KnjigaId = 5,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2021, 6, 15, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 21, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 13,
                    StatusId = 3,
                    KnjigaId = 5,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2021, 7, 15, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 7, 21, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 14,
                    StatusId = 3,
                    KnjigaId = 6,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2021, 4, 15, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 4, 21, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 15,
                    StatusId = 3,
                    KnjigaId = 6,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2021, 5, 15, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 21, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 16,
                    StatusId = 3,
                    KnjigaId = 7,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2021, 3, 14, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 19, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 17,
                    StatusId = 3,
                    KnjigaId = 7,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2021, 5, 14, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 19, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 18,
                    StatusId = 3,
                    KnjigaId = 7,
                    ClanId = 8,
                    DatumRezervacije = new DateTime(2021, 3, 14, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 19, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 19,
                    StatusId = 3,
                    KnjigaId = 7,
                    ClanId = 9,
                    DatumRezervacije = new DateTime(2021, 5, 14, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 19, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 20,
                    StatusId = 3,
                    KnjigaId = 7,
                    ClanId = 10,
                    DatumRezervacije = new DateTime(2021, 5, 14, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 19, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 21,
                    StatusId = 3,
                    KnjigaId = 8,
                    ClanId = 1,
                    DatumRezervacije = new DateTime(2021, 1, 14, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 1, 19, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 22,
                    StatusId = 3,
                    KnjigaId = 8,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2021, 2, 13, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 1, 18, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 23,
                    StatusId = 3,
                    KnjigaId = 8,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2021, 2, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 24,
                    StatusId = 3,
                    KnjigaId = 8,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2021, 2, 9, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 14, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 25,
                    StatusId = 3,
                    KnjigaId = 8,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2021, 2, 9, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 14, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 26,
                    StatusId = 3,
                    KnjigaId = 8,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2021, 2, 9, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 14, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 27,
                    StatusId = 3,
                    KnjigaId = 8,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2021, 3, 9, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 14, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 28,
                    StatusId = 3,
                    KnjigaId = 8,
                    ClanId = 8,
                    DatumRezervacije = new DateTime(2021, 4, 9, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 4, 14, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 29,
                    StatusId = 3,
                    KnjigaId = 8,
                    ClanId = 9,
                    DatumRezervacije = new DateTime(2021, 5, 5, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 10, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 30,
                    StatusId = 3,
                    KnjigaId = 8,
                    ClanId = 10,
                    DatumRezervacije = new DateTime(2021, 6, 5, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 10, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 31,
                    StatusId = 3,
                    KnjigaId = 9,
                    ClanId = 1,
                    DatumRezervacije = new DateTime(2021, 2, 14, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 19, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 32,
                    StatusId = 3,
                    KnjigaId = 9,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2021, 3, 13, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 18, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 33,
                    StatusId = 3,
                    KnjigaId = 9,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2021, 3, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 34,
                    StatusId = 3,
                    KnjigaId = 9,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2021, 2, 9, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 14, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 35,
                    StatusId = 3,
                    KnjigaId = 9,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2021, 5, 9, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 14, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 36,
                    StatusId = 3,
                    KnjigaId = 9,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2021, 4, 9, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 4, 14, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 37,
                    StatusId = 3,
                    KnjigaId = 9,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2021, 3, 9, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 14, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 38,
                    StatusId = 3,
                    KnjigaId = 9,
                    ClanId = 8,
                    DatumRezervacije = new DateTime(2021, 4, 9, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 4, 14, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 39,
                    StatusId = 3,
                    KnjigaId = 8,
                    ClanId = 9,
                    DatumRezervacije = new DateTime(2021, 5, 5, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 10, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 40,
                    StatusId = 3,
                    KnjigaId = 9,
                    ClanId = 10,
                    DatumRezervacije = new DateTime(2021, 5, 6, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 11, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 41,
                    StatusId = 3,
                    KnjigaId = 10,
                    ClanId = 1,
                    DatumRezervacije = new DateTime(2020, 12, 4, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 12, 9, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 42,
                    StatusId = 3,
                    KnjigaId = 10,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2020, 12, 4, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 12, 9, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 43,
                    StatusId = 3,
                    KnjigaId = 10,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2021, 12, 4, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 12, 9, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 44,
                    StatusId = 3,
                    KnjigaId = 11,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2020, 12, 10, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 12, 15, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 45,
                    StatusId = 3,
                    KnjigaId = 11,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2020, 8, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 8, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 46,
                    StatusId = 3,
                    KnjigaId = 12,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2020, 7, 19, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 25, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 47,
                    StatusId = 3,
                    KnjigaId = 12,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 18, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 48,
                    StatusId = 3,
                    KnjigaId = 13,
                    ClanId = 8,
                    DatumRezervacije = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 18, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 49,
                    StatusId = 3,
                    KnjigaId = 13,
                    ClanId = 9,
                    DatumRezervacije = new DateTime(2020, 5, 17, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 22, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 50,
                    StatusId = 3,
                    KnjigaId = 13,
                    ClanId = 10,
                    DatumRezervacije = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 18, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 51,
                    StatusId = 3,
                    KnjigaId = 13,
                    ClanId = 1,
                    DatumRezervacije = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 11, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 52,
                    StatusId = 3,
                    KnjigaId = 13,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 11, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 53,
                    StatusId = 3,
                    KnjigaId = 14,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 18, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 54,
                    StatusId = 3,
                    KnjigaId = 14,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2020, 5, 17, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 22, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 55,
                    StatusId = 3,
                    KnjigaId = 14,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 18, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 56,
                    StatusId = 3,
                    KnjigaId = 14,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 11, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 57,
                    StatusId = 3,
                    KnjigaId = 14,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 11, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 58,
                    StatusId = 3,
                    KnjigaId = 15,
                    ClanId = 8,
                    DatumRezervacije = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 18, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 59,
                    StatusId = 3,
                    KnjigaId = 15,
                    ClanId = 9,
                    DatumRezervacije = new DateTime(2020, 5, 17, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 22, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 60,
                    StatusId = 3,
                    KnjigaId = 15,
                    ClanId = 10,
                    DatumRezervacije = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 18, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 61,
                    StatusId = 3,
                    KnjigaId = 15,
                    ClanId = 1,
                    DatumRezervacije = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 11, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 62,
                    StatusId = 3,
                    KnjigaId = 15,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 11, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 63,
                    StatusId = 3,
                    KnjigaId = 15,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 18, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 64,
                    StatusId = 3,
                    KnjigaId = 15,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2020, 5, 17, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 22, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 65,
                    StatusId = 3,
                    KnjigaId = 15,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 7, 18, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 66,
                    StatusId = 3,
                    KnjigaId = 15,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 11, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 67,
                    StatusId = 3,
                    KnjigaId = 15,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 11, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 68,
                    StatusId = 3,
                    KnjigaId = 16,
                    ClanId = 8,
                    DatumRezervacije = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 11, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 69,
                    StatusId = 3,
                    KnjigaId = 16,
                    ClanId = 9,
                    DatumRezervacije = new DateTime(2021, 1, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 1, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 70,
                    StatusId = 3,
                    KnjigaId = 16,
                    ClanId = 10,
                    DatumRezervacije = new DateTime(2021, 1, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 1, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 71,
                    StatusId = 3,
                    KnjigaId = 17,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2021, 1, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 1, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 72,
                    StatusId = 3,
                    KnjigaId = 18,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2021, 1, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 1, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 73,
                    StatusId = 3,
                    KnjigaId = 18,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2021, 1, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 1, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 74,
                    StatusId = 3,
                    KnjigaId = 19,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2020, 9, 15, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 9, 20, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 75,
                    StatusId = 3,
                    KnjigaId = 19,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2020, 9, 15, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 9, 20, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 76,
                    StatusId = 3,
                    KnjigaId = 20,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2020, 10, 11, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 9, 16, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 77,
                    StatusId = 3,
                    KnjigaId = 20,
                    ClanId = 8,
                    DatumRezervacije = new DateTime(2020, 9, 15, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 9, 20, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 78,
                    StatusId = 3,
                    KnjigaId = 21,
                    ClanId = 9,
                    DatumRezervacije = new DateTime(2020, 11, 25, 1, 10, 30),
                    DatumIsteka = new DateTime(2020, 9, 30, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 79,
                    StatusId = 3,
                    KnjigaId = 21,
                    ClanId = 10,
                    DatumRezervacije = new DateTime(2021, 1, 24, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 1, 29, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 80,
                    StatusId = 3,
                    KnjigaId = 21,
                    ClanId = 1,
                    DatumRezervacije = new DateTime(2021, 1, 18, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 1, 23, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 81,
                    StatusId = 3,
                    KnjigaId = 21,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2021, 2, 13, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 18, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 82,
                    StatusId = 3,
                    KnjigaId = 21,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2021, 2, 18, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 23, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 83,
                    StatusId = 3,
                    KnjigaId = 21,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2021, 3, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 84,
                    StatusId = 3,
                    KnjigaId = 21,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2021, 3, 14, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 19, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 85,
                    StatusId = 3,
                    KnjigaId = 21,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2021, 2, 18, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 23, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 86,
                    StatusId = 3,
                    KnjigaId = 21,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2021, 2, 19, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 24, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 87,
                    StatusId = 3,
                    KnjigaId = 21,
                    ClanId = 8,
                    DatumRezervacije = new DateTime(2021, 2, 19, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 24, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 88,
                    StatusId = 3,
                    KnjigaId = 22,
                    ClanId = 9,
                    DatumRezervacije = new DateTime(2021, 2, 20, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 25, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 89,
                    StatusId = 3,
                    KnjigaId = 22,
                    ClanId = 10,
                    DatumRezervacije = new DateTime(2021, 3, 25, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 30, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 90,
                    StatusId = 3,
                    KnjigaId = 23,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2021, 3, 25, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 30, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 91,
                    StatusId = 3,
                    KnjigaId = 23,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2021, 3, 25, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 30, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 92,
                    StatusId = 3,
                    KnjigaId = 24,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2021, 4, 21, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 4, 26, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 93,
                    StatusId = 3,
                    KnjigaId = 24,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2021, 5, 20, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 25, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 94,
                    StatusId = 3,
                    KnjigaId = 25,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2021, 5, 20, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 25, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 95,
                    StatusId = 3,
                    KnjigaId = 25,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2021, 6, 11, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 16, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 96,
                    StatusId = 3,
                    KnjigaId = 26,
                    ClanId = 8,
                    DatumRezervacije = new DateTime(2021, 6, 4, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 9, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 97,
                    StatusId = 3,
                    KnjigaId = 26,
                    ClanId = 9,
                    DatumRezervacije = new DateTime(2021, 6, 9, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 14, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 98,
                    StatusId = 3,
                    KnjigaId = 26,
                    ClanId = 10,
                    DatumRezervacije = new DateTime(2021, 6, 10, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 15, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 99,
                    StatusId = 3,
                    KnjigaId = 27,
                    ClanId = 1,
                    DatumRezervacije = new DateTime(2021, 4, 10, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 4, 15, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 100,
                    StatusId = 3,
                    KnjigaId = 27,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2021, 5, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 101,
                    StatusId = 3,
                    KnjigaId = 28,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2021, 5, 2, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 7, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 102,
                    StatusId = 3,
                    KnjigaId = 28,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2021, 5, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 103,
                    StatusId = 3,
                    KnjigaId = 28,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2021, 5, 6, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 11, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 104,
                    StatusId = 3,
                    KnjigaId = 29,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2021, 6, 7, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 12, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 105,
                    StatusId = 3,
                    KnjigaId = 30,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2021, 6, 7, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 12, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 106,
                    StatusId = 2,
                    KnjigaId = 21,
                    ClanId = 1,
                    DatumRezervacije = new DateTime(2021, 1, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 1, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 107,
                    StatusId = 2,
                    KnjigaId = 21,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2021, 2, 13, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 18, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 108,
                    StatusId = 2,
                    KnjigaId = 21,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2021, 2, 18, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 23, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 109,
                    StatusId = 2,
                    KnjigaId = 21,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2021, 3, 23, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 28, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 110,
                    StatusId = 2,
                    KnjigaId = 21,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2021, 3, 14, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 19, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 111,
                    StatusId = 2,
                    KnjigaId = 21,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2021, 2, 18, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 23, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 112,
                    StatusId = 2,
                    KnjigaId = 21,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2021, 2, 19, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 24, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 113,
                    StatusId = 2,
                    KnjigaId = 21,
                    ClanId = 8,
                    DatumRezervacije = new DateTime(2021, 2, 19, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 24, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 114,
                    StatusId = 2,
                    KnjigaId = 22,
                    ClanId = 9,
                    DatumRezervacije = new DateTime(2021, 2, 20, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 2, 25, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 115,
                    StatusId = 2,
                    KnjigaId = 22,
                    ClanId = 10,
                    DatumRezervacije = new DateTime(2021, 3, 25, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 30, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 116,
                    StatusId = 2,
                    KnjigaId = 23,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2021, 3, 25, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 30, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 117,
                    StatusId = 2,
                    KnjigaId = 23,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2021, 3, 25, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 3, 30, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 118,
                    StatusId = 2,
                    KnjigaId = 24,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2021, 4, 21, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 4, 26, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 119,
                    StatusId = 2,
                    KnjigaId = 24,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2021, 5, 20, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 25, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 120,
                    StatusId = 2,
                    KnjigaId = 25,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2021, 5, 20, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 25, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 121,
                    StatusId = 2,
                    KnjigaId = 25,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2021, 6, 11, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 16, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 122,
                    StatusId = 2,
                    KnjigaId = 26,
                    ClanId = 8,
                    DatumRezervacije = new DateTime(2021, 6, 4, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 9, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 123,
                    StatusId = 2,
                    KnjigaId = 26,
                    ClanId = 9,
                    DatumRezervacije = new DateTime(2021, 6, 9, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 14, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 124,
                    StatusId = 2,
                    KnjigaId = 26,
                    ClanId = 10,
                    DatumRezervacije = new DateTime(2021, 6, 10, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 15, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 125,
                    StatusId = 2,
                    KnjigaId = 27,
                    ClanId = 1,
                    DatumRezervacije = new DateTime(2021, 4, 1, 12, 15, 25),
                    DatumIsteka = new DateTime(2021, 4, 6, 1, 3, 30)
                },
                new Rezervacija
                {
                    Id = 126,
                    StatusId = 2,
                    KnjigaId = 27,
                    ClanId = 2,
                    DatumRezervacije = new DateTime(2021, 5, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 127,
                    StatusId = 2,
                    KnjigaId = 28,
                    ClanId = 3,
                    DatumRezervacije = new DateTime(2021, 5, 2, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 7, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 128,
                    StatusId = 2,
                    KnjigaId = 28,
                    ClanId = 4,
                    DatumRezervacije = new DateTime(2021, 5, 1, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 6, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 129,
                    StatusId = 2,
                    KnjigaId = 28,
                    ClanId = 5,
                    DatumRezervacije = new DateTime(2021, 5, 6, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 5, 11, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 130,
                    StatusId = 2,
                    KnjigaId = 29,
                    ClanId = 6,
                    DatumRezervacije = new DateTime(2021, 6, 7, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 12, 1, 10, 30)
                },
                new Rezervacija
                {
                    Id = 131,
                    StatusId = 2,
                    KnjigaId = 30,
                    ClanId = 7,
                    DatumRezervacije = new DateTime(2021, 6, 7, 1, 10, 30),
                    DatumIsteka = new DateTime(2021, 6, 12, 1, 10, 30)
                }
                );
            #endregion

            #region Posudbe
            modelBuilder.Entity<Posudba>().HasData(
                new Posudba
                {
                    Id = 1,
                    KopijaId = 1,
                    ClanId = 1,
                    DatumPreuzeca = new DateTime(2021, 1, 2, 1, 20, 30),
                    DatumPovrata = new DateTime(2021, 1, 28, 1, 20, 30)
                },
                new Posudba
                {
                    Id = 2,
                    KopijaId = 2,
                    ClanId = 2,
                    DatumPreuzeca = new DateTime(2021, 1, 3, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 1, 30, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 3,
                    KopijaId = 3,
                    ClanId = 3,
                    DatumPreuzeca = new DateTime(2021, 3, 2, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 3, 30, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 4,
                    KopijaId = 4,
                    ClanId = 4,
                    DatumPreuzeca = new DateTime(2021, 2, 3, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 2, 27, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 5,
                    KopijaId = 5,
                    ClanId = 5,
                    DatumPreuzeca = new DateTime(2021, 2, 2, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 2, 27, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 6,
                    KopijaId = 6,
                    ClanId = 6,
                    DatumPreuzeca = new DateTime(2021, 4, 2, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 4, 30, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 7,
                    KopijaId = 7,
                    ClanId = 7,
                    DatumPreuzeca = new DateTime(2021, 4, 2, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 4, 30, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 8,
                    KopijaId = 8,
                    ClanId = 8,
                    DatumPreuzeca = new DateTime(2021, 5, 2, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 5, 30, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 9,
                    KopijaId = 9,
                    ClanId = 9,
                    DatumPreuzeca = new DateTime(2021, 5, 2, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 5, 30, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 10,
                    KopijaId = 10,
                    ClanId = 10,
                    DatumPreuzeca = new DateTime(2021, 7, 2, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 7, 30, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 11,
                    KopijaId = 11,
                    ClanId = 1,
                    DatumPreuzeca = new DateTime(2021, 7, 2, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 7, 30, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 12,
                    KopijaId = 12,
                    ClanId = 2,
                    DatumPreuzeca = new DateTime(2021, 6, 17, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 7, 15, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 13,
                    KopijaId = 13,
                    ClanId = 3,
                    DatumPreuzeca = new DateTime(2021, 7, 17, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 8, 14, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 14,
                    KopijaId = 14,
                    ClanId = 4,
                    DatumPreuzeca = new DateTime(2021, 4, 17, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 5, 21, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 15,
                    KopijaId = 15,
                    ClanId = 5,
                    DatumPreuzeca = new DateTime(2021, 5, 18, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 25, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 16,
                    KopijaId = 16,
                    ClanId = 6,
                    DatumPreuzeca = new DateTime(2021, 3, 14, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 4, 19, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 17,
                    KopijaId = 17,
                    ClanId = 7,
                    DatumPreuzeca = new DateTime(2021, 5, 16, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 19, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 18,
                    KopijaId = 18,
                    ClanId = 8,
                    DatumPreuzeca = new DateTime(2021, 3, 15, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 4, 25, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 19,
                    KopijaId = 19,
                    ClanId = 9,
                    DatumPreuzeca = new DateTime(2021, 5, 16, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 18, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 20,
                    KopijaId = 20,
                    ClanId = 10,
                    DatumPreuzeca = new DateTime(2021, 5, 14, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 19, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 21,
                    KopijaId = 21,
                    ClanId = 1,
                    DatumPreuzeca = new DateTime(2021, 1, 14, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 2, 19, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 22,
                    KopijaId = 22,
                    ClanId = 2,
                    DatumPreuzeca = new DateTime(2021, 2, 13, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 2, 18, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 23,
                    KopijaId = 23,
                    ClanId = 3,
                    DatumPreuzeca = new DateTime(2021, 2, 1, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 3, 6, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 24,
                    KopijaId = 24,
                    ClanId = 4,
                    DatumPreuzeca = new DateTime(2021, 2, 9, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 3, 14, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 25,
                    KopijaId = 25,
                    ClanId = 5,
                    DatumPreuzeca = new DateTime(2021, 2, 9, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 3, 14, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 26,
                    KopijaId = 26,
                    ClanId = 6,
                    DatumPreuzeca = new DateTime(2021, 2, 9, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 3, 14, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 27,
                    KopijaId = 27,
                    ClanId = 7,
                    DatumPreuzeca = new DateTime(2021, 3, 9, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 4, 14, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 28,
                    KopijaId = 28,
                    ClanId = 8,
                    DatumPreuzeca = new DateTime(2021, 4, 9, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 5, 14, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 29,
                    KopijaId = 29,
                    ClanId = 9,
                    DatumPreuzeca = new DateTime(2021, 5, 5, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 10, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 30,
                    KopijaId = 30,
                    ClanId = 10,
                    DatumPreuzeca = new DateTime(2021, 6, 5, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 7, 10, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 31,
                    KopijaId = 31,
                    ClanId = 1,
                    DatumPreuzeca = new DateTime(2021, 2, 14, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 3, 19, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 32,
                    KopijaId = 32,
                    ClanId = 2,
                    DatumPreuzeca = new DateTime(2021, 3, 13, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 4, 18, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 33,
                    KopijaId = 33,
                    ClanId = 3,
                    DatumPreuzeca = new DateTime(2021, 3, 2, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 4, 6, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 34,
                    KopijaId = 34,
                    ClanId = 4,
                    DatumPreuzeca = new DateTime(2021, 2, 9, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 3, 14, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 35,
                    KopijaId = 35,
                    ClanId = 5,
                    DatumPreuzeca = new DateTime(2021, 5, 10, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 14, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 36,
                    KopijaId = 36,
                    ClanId = 6,
                    DatumPreuzeca = new DateTime(2021, 4, 9, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 5, 14, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 37,
                    KopijaId = 37,
                    ClanId = 7,
                    DatumPreuzeca = new DateTime(2021, 3, 9, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 4, 14, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 38,
                    KopijaId = 38,
                    ClanId = 8,
                    DatumPreuzeca = new DateTime(2021, 4, 9, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 5, 14, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 39,
                    KopijaId = 39,
                    ClanId = 9,
                    DatumPreuzeca = new DateTime(2021, 5, 5, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 10, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 40,
                    KopijaId = 40,
                    ClanId = 10,
                    DatumPreuzeca = new DateTime(2021, 5, 6, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 11, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 41,
                    KopijaId = 41,
                    ClanId = 1,
                    DatumPreuzeca = new DateTime(2020, 12, 4, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 1, 10, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 42,
                    KopijaId = 42,
                    ClanId = 2,
                    DatumPreuzeca = new DateTime(2020, 12, 4, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 1, 9, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 43,
                    KopijaId = 43,
                    ClanId = 3,
                    DatumPreuzeca = new DateTime(2020, 12, 4, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 1, 9, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 44,
                    KopijaId = 44,
                    ClanId = 4,
                    DatumPreuzeca = new DateTime(2020, 12, 10, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 1, 15, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 45,
                    KopijaId = 45,
                    ClanId = 5,
                    DatumPreuzeca = new DateTime(2020, 8, 1, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 9, 6, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 46,
                    KopijaId = 46,
                    ClanId = 6,
                    DatumPreuzeca = new DateTime(2020, 7, 19, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 8, 25, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 47,
                    KopijaId = 47,
                    ClanId = 7,
                    DatumPreuzeca = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 6, 18, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 48,
                    KopijaId = 48,
                    ClanId = 8,
                    DatumPreuzeca = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 6, 18, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 49,
                    KopijaId = 49,
                    ClanId = 9,
                    DatumPreuzeca = new DateTime(2020, 5, 17, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 6, 22, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 50,
                    KopijaId = 50,
                    ClanId = 10,
                    DatumPreuzeca = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 6, 18, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 51,
                    KopijaId = 51,
                    ClanId = 1,
                    DatumPreuzeca = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 12, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 52,
                    KopijaId = 52,
                    ClanId = 2,
                    DatumPreuzeca = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 12, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 53,
                    KopijaId = 53,
                    ClanId = 3,
                    DatumPreuzeca = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 6, 18, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 54,
                    KopijaId = 54,
                    ClanId = 4,
                    DatumPreuzeca = new DateTime(2020, 5, 17, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 6, 22, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 55,
                    KopijaId = 55,
                    ClanId = 5,
                    DatumPreuzeca = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 6, 18, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 56,
                    KopijaId = 56,
                    ClanId = 6,
                    DatumPreuzeca = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 12, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 57,
                    KopijaId = 57,
                    ClanId = 7,
                    DatumPreuzeca = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 12, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 58,
                    KopijaId = 58,
                    ClanId = 8,
                    DatumPreuzeca = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 6, 18, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 59,
                    KopijaId = 59,
                    ClanId = 9,
                    DatumPreuzeca = new DateTime(2020, 5, 17, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 6, 22, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 60,
                    KopijaId = 60,
                    ClanId = 10,
                    DatumPreuzeca = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 6, 18, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 61,
                    KopijaId = 61,
                    ClanId = 1,
                    DatumPreuzeca = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 12, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 62,
                    KopijaId = 62,
                    ClanId = 2,
                    DatumPreuzeca = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 12, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 63,
                    KopijaId = 63,
                    ClanId = 3,
                    DatumPreuzeca = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 6, 18, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 64,
                    KopijaId = 64,
                    ClanId = 4,
                    DatumPreuzeca = new DateTime(2020, 5, 17, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 6, 22, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 65,
                    KopijaId = 65,
                    ClanId = 5,
                    DatumPreuzeca = new DateTime(2020, 5, 13, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 6, 18, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 66,
                    KopijaId = 66,
                    ClanId = 6,
                    DatumPreuzeca = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 12, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 67,
                    KopijaId = 67,
                    ClanId = 7,
                    DatumPreuzeca = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 12, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 68,
                    KopijaId = 68,
                    ClanId = 8,
                    DatumPreuzeca = new DateTime(2020, 11, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 12, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 69,
                    KopijaId = 69,
                    ClanId = 9,
                    DatumPreuzeca = new DateTime(2021, 1, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 2, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 70,
                    KopijaId = 70,
                    ClanId = 10,
                    DatumPreuzeca = new DateTime(2021, 1, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 2, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 71,
                    KopijaId = 73,
                    ClanId = 2,
                    DatumPreuzeca = new DateTime(2021, 1, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 2, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 72,
                    KopijaId = 75,
                    ClanId = 3,
                    DatumPreuzeca = new DateTime(2021, 1, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 2, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 73,
                    KopijaId = 76,
                    ClanId = 4,
                    DatumPreuzeca = new DateTime(2021, 1, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 2, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 74,
                    KopijaId = 80,
                    ClanId = 5,
                    DatumPreuzeca = new DateTime(2020, 9, 15, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 10, 20, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 75,
                    KopijaId = 81,
                    ClanId = 6,
                    DatumPreuzeca = new DateTime(2020, 9, 15, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 10, 20, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 76,
                    KopijaId = 85,
                    ClanId = 7,
                    DatumPreuzeca = new DateTime(2020, 8, 11, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 9, 16, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 77,
                    KopijaId = 86,
                    ClanId = 8,
                    DatumPreuzeca = new DateTime(2020, 9, 15, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 10, 20, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 78,
                    KopijaId = 90,
                    ClanId = 9,
                    DatumPreuzeca = new DateTime(2020, 9, 25, 1, 10, 30),
                    DatumPovrata = new DateTime(2020, 10, 30, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 79,
                    KopijaId = 91,
                    ClanId = 10,
                    DatumPreuzeca = new DateTime(2021, 1, 24, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 2, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 80,
                    KopijaId = 92,
                    ClanId = 1,
                    DatumPreuzeca = new DateTime(2021, 1, 18, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 2, 23, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 81,
                    KopijaId = 93,
                    ClanId = 2,
                    DatumPreuzeca = new DateTime(2021, 2, 13, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 3, 18, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 82,
                    KopijaId = 94,
                    ClanId = 3,
                    DatumPreuzeca = new DateTime(2021, 2, 18, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 3, 23, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 83,
                    KopijaId = 95,
                    ClanId = 4,
                    DatumPreuzeca = new DateTime(2021, 3, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 4, 28, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 84,
                    KopijaId = 96,
                    ClanId = 5,
                    DatumPreuzeca = new DateTime(2021, 3, 14, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 4, 19, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 85,
                    KopijaId = 97,
                    ClanId = 6,
                    DatumPreuzeca = new DateTime(2021, 2, 18, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 3, 23, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 86,
                    KopijaId = 98,
                    ClanId = 7,
                    DatumPreuzeca = new DateTime(2021, 2, 19, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 3, 24, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 87,
                    KopijaId = 99,
                    ClanId = 8,
                    DatumPreuzeca = new DateTime(2021, 2, 19, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 3, 24, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 88,
                    KopijaId = 100,
                    ClanId = 9,
                    DatumPreuzeca = new DateTime(2021, 2, 23, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 3, 25, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 89,
                    KopijaId = 101,
                    ClanId = 10,
                    DatumPreuzeca = new DateTime(2021, 3, 27, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 4, 30, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 90,
                    KopijaId = 103,
                    ClanId = 2,
                    DatumPreuzeca = new DateTime(2021, 3, 25, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 4, 30, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 91,
                    KopijaId = 104,
                    ClanId = 3,
                    DatumPreuzeca = new DateTime(2021, 3, 25, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 4, 30, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 92,
                    KopijaId = 105,
                    ClanId = 4,
                    DatumPreuzeca = new DateTime(2021, 4, 21, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 5, 26, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 93,
                    KopijaId = 106,
                    ClanId = 5,
                    DatumPreuzeca = new DateTime(2021, 5, 20, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 25, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 94,
                    KopijaId = 107,
                    ClanId = 6,
                    DatumPreuzeca = new DateTime(2021, 5, 20, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 25, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 95,
                    KopijaId = 108,
                    ClanId = 7,
                    DatumPreuzeca = new DateTime(2021, 6, 11, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 7, 16, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 96,
                    KopijaId = 109,
                    ClanId = 8,
                    DatumPreuzeca = new DateTime(2021, 6, 4, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 7, 9, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 97,
                    KopijaId = 110,
                    ClanId = 9,
                    DatumPreuzeca = new DateTime(2021, 6, 9, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 7, 14, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 98,
                    KopijaId = 111,
                    ClanId = 10,
                    DatumPreuzeca = new DateTime(2021, 6, 10, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 7, 15, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 99,
                    KopijaId = 112,
                    ClanId = 1,
                    DatumPreuzeca = new DateTime(2021, 4, 10, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 5, 15, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 100,
                    KopijaId = 113,
                    ClanId = 2,
                    DatumPreuzeca = new DateTime(2021, 5, 1, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 6, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 101,
                    KopijaId = 116,
                    ClanId = 3,
                    DatumPreuzeca = new DateTime(2021, 5, 2, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 7, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 102,
                    KopijaId = 117,
                    ClanId = 4,
                    DatumPreuzeca = new DateTime(2021, 5, 1, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 6, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 103,
                    KopijaId = 118,
                    ClanId = 5,
                    DatumPreuzeca = new DateTime(2021, 5, 6, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 6, 11, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 104,
                    KopijaId = 121,
                    ClanId = 6,
                    DatumPreuzeca = new DateTime(2021, 6, 7, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 7, 12, 1, 10, 30)
                },
                new Posudba
                {
                    Id = 105,
                    KopijaId = 124,
                    ClanId = 7,
                    DatumPreuzeca = new DateTime(2021, 6, 7, 1, 10, 30),
                    DatumPovrata = new DateTime(2021, 7, 12, 1, 10, 30)
                }
                );
            #endregion

            #region Recenzije
            modelBuilder.Entity<Recenzija>().HasData(
                new Recenzija
                {
                    Id = 1,
                    KnjigaId = 1,
                    ClanId = 1,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 2,
                    KnjigaId = 2,
                    ClanId = 2,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 3,
                    KnjigaId = 2,
                    ClanId = 3,
                    Ocjena = 4,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 4,
                    KnjigaId = 3,
                    ClanId = 3,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 5,
                    KnjigaId = 3,
                    ClanId = 4,
                    Ocjena = 3,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 6,
                    KnjigaId = 4,
                    ClanId = 4,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 7,
                    KnjigaId = 4,
                    ClanId = 5,
                    Ocjena = 4,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 8,
                    KnjigaId = 5,
                    ClanId = 2,
                    Ocjena = 4,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 9,
                    KnjigaId = 5,
                    ClanId = 3,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 10,
                    KnjigaId = 6,
                    ClanId = 7,
                    Ocjena = 3,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 11,
                    KnjigaId = 7,
                    ClanId = 7,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 12,
                    KnjigaId = 7,
                    ClanId = 2,
                    Ocjena = 1,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 13,
                    KnjigaId = 8,
                    ClanId = 8,
                    Ocjena = 2,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 14,
                    KnjigaId = 8,
                    ClanId = 9,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 15,
                    KnjigaId = 9,
                    ClanId = 2,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 16,
                    KnjigaId = 9,
                    ClanId = 3,
                    Ocjena = 4,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 17,
                    KnjigaId = 10,
                    ClanId = 3,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 18,
                    KnjigaId = 10,
                    ClanId = 4,
                    Ocjena = 3,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 19,
                    KnjigaId = 10,
                    ClanId = 4,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 20,
                    KnjigaId = 11,
                    ClanId = 5,
                    Ocjena = 4,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 21,
                    KnjigaId = 11,
                    ClanId = 2,
                    Ocjena = 4,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 22,
                    KnjigaId = 12,
                    ClanId = 3,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 23,
                    KnjigaId = 12,
                    ClanId = 7,
                    Ocjena = 3,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 24,
                    KnjigaId = 13,
                    ClanId = 7,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 25,
                    KnjigaId = 13,
                    ClanId = 2,
                    Ocjena = 1,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 26,
                    KnjigaId = 14,
                    ClanId = 8,
                    Ocjena = 2,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },

                new Recenzija
                {
                    Id = 27,
                    KnjigaId = 14,
                    ClanId = 9,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 28,
                    KnjigaId = 15,
                    ClanId = 9,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 29,
                    KnjigaId = 15,
                    ClanId = 4,
                    Ocjena = 3,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 30,
                    KnjigaId = 16,
                    ClanId = 4,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 31,
                    KnjigaId = 16,
                    ClanId = 5,
                    Ocjena = 4,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 32,
                    KnjigaId = 17,
                    ClanId = 2,
                    Ocjena = 4,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 33,
                    KnjigaId = 17,
                    ClanId = 3,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 34,
                    KnjigaId = 18,
                    ClanId = 7,
                    Ocjena = 3,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 35,
                    KnjigaId = 18,
                    ClanId = 7,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 36,
                    KnjigaId = 19,
                    ClanId = 2,
                    Ocjena = 1,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 37,
                    KnjigaId = 19,
                    ClanId = 8,
                    Ocjena = 2,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 38,
                    KnjigaId = 20,
                    ClanId = 9,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 39,
                    KnjigaId = 20,
                    ClanId = 2,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 40,
                    KnjigaId = 21,
                    ClanId = 3,
                    Ocjena = 4,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 41,
                    KnjigaId = 22,
                    ClanId = 3,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 42,
                    KnjigaId = 22,
                    ClanId = 4,
                    Ocjena = 3,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 43,
                    KnjigaId = 23,
                    ClanId = 4,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 44,
                    KnjigaId = 23,
                    ClanId = 5,
                    Ocjena = 4,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 45,
                    KnjigaId = 24,
                    ClanId = 2,
                    Ocjena = 4,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 46,
                    KnjigaId = 24,
                    ClanId = 3,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 47,
                    KnjigaId = 25,
                    ClanId = 7,
                    Ocjena = 3,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 48,
                    KnjigaId = 26,
                    ClanId = 7,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 49,
                    KnjigaId = 26,
                    ClanId = 2,
                    Ocjena = 1,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 50,
                    KnjigaId = 27,
                    ClanId = 8,
                    Ocjena = 2,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 51,
                    KnjigaId = 27,
                    ClanId = 10,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 52,
                    KnjigaId = 28,
                    ClanId = 8,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 53,
                    KnjigaId = 29,
                    ClanId = 8,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 54,
                    KnjigaId = 29,
                    ClanId = 10,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                },
                new Recenzija
                {
                    Id = 55,
                    KnjigaId = 30,
                    ClanId = 3,
                    Ocjena = 5,
                    DatumOcjene = new DateTime(2021, 5, 2, 12, 10, 20)
                }
                );
            #endregion

            #region Uplate
            modelBuilder.Entity<UplataClanarine>().HasData(
                new UplataClanarine
                {
                    Id = 1,
                    ClanId = 1,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 7, 8)
                },
                new UplataClanarine
                {
                    Id = 2,
                    ClanId = 2,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 7, 10)
                },
                new UplataClanarine
                {
                    Id = 3,
                    ClanId = 3,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 7, 12)
                },
                new UplataClanarine
                {
                    Id = 4,
                    ClanId = 4,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 7, 13)
                },
                new UplataClanarine
                {
                    Id = 5,
                    ClanId = 5,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 7, 13)
                },
                 new UplataClanarine
                 {
                     Id = 6,
                     ClanId = 6,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 7, 15)
                 },
                 new UplataClanarine
                 {
                     Id = 7,
                     ClanId = 7,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 7, 18)
                 },
                 new UplataClanarine
                 {
                     Id = 8,
                     ClanId = 8,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 7, 20)
                 },
                 new UplataClanarine
                 {
                     Id = 9,
                     ClanId = 9,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 7, 21)
                 },
                 new UplataClanarine
                 {
                     Id = 10,
                     ClanId = 10,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 7, 23)
                 },
                 new UplataClanarine
                 {
                     Id = 11,
                     ClanId = 1,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 8, 8)
                 },
                new UplataClanarine
                {
                    Id = 12,
                    ClanId = 2,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 8, 10)
                },
                new UplataClanarine
                {
                    Id = 13,
                    ClanId = 3,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 8, 12)
                },
                new UplataClanarine
                {
                    Id = 14,
                    ClanId = 4,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 8, 13)
                },
                new UplataClanarine
                {
                    Id = 15,
                    ClanId = 5,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 8, 13)
                },
                 new UplataClanarine
                 {
                     Id = 16,
                     ClanId = 6,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 8, 15)
                 },
                 new UplataClanarine
                 {
                     Id = 17,
                     ClanId = 7,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 8, 18)
                 },
                 new UplataClanarine
                 {
                     Id = 18,
                     ClanId = 8,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 8, 20)
                 },
                 new UplataClanarine
                 {
                     Id = 19,
                     ClanId = 9,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 8, 21)
                 },
                 new UplataClanarine
                 {
                     Id = 20,
                     ClanId = 10,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 8, 23)
                 },
                 new UplataClanarine
                 {
                     Id = 21,
                     ClanId = 1,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 9, 8)
                 },
                new UplataClanarine
                {
                    Id = 22,
                    ClanId = 2,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 9, 10)
                },
                new UplataClanarine
                {
                    Id = 23,
                    ClanId = 3,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 9, 12)
                },
                new UplataClanarine
                {
                    Id = 24,
                    ClanId = 4,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 9, 13)
                },
                new UplataClanarine
                {
                    Id = 25,
                    ClanId = 5,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 9, 13)
                },
                 new UplataClanarine
                 {
                     Id = 26,
                     ClanId = 6,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 9, 15)
                 },
                 new UplataClanarine
                 {
                     Id = 27,
                     ClanId = 7,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 9, 18)
                 },
                 new UplataClanarine
                 {
                     Id = 28,
                     ClanId = 8,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 9, 20)
                 },
                 new UplataClanarine
                 {
                     Id = 29,
                     ClanId = 9,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 9, 21)
                 },
                 new UplataClanarine
                 {
                     Id = 30,
                     ClanId = 10,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 9, 23)
                 }, new UplataClanarine
                 {
                     Id = 31,
                     ClanId = 1,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 10, 8)
                 },
                new UplataClanarine
                {
                    Id = 32,
                    ClanId = 2,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 10, 10)
                },
                new UplataClanarine
                {
                    Id = 33,
                    ClanId = 3,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 10, 12)
                },
                new UplataClanarine
                {
                    Id = 34,
                    ClanId = 4,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 10, 13)
                },
                new UplataClanarine
                {
                    Id = 35,
                    ClanId = 5,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 10, 13)
                },
                 new UplataClanarine
                 {
                     Id = 36,
                     ClanId = 6,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 10, 15)
                 },
                 new UplataClanarine
                 {
                     Id = 37,
                     ClanId = 7,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 10, 18)
                 },
                 new UplataClanarine
                 {
                     Id = 38,
                     ClanId = 8,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 10, 20)
                 },
                 new UplataClanarine
                 {
                     Id = 39,
                     ClanId = 9,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 10, 21)
                 },
                 new UplataClanarine
                 {
                     Id = 40,
                     ClanId = 10,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 10, 23)
                 },
                 new UplataClanarine
                 {
                     Id = 41,
                     ClanId = 1,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 11, 8)
                 },
                new UplataClanarine
                {
                    Id = 42,
                    ClanId = 2,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 11, 10)
                },
                new UplataClanarine
                {
                    Id = 43,
                    ClanId = 3,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 11, 12)
                },
                new UplataClanarine
                {
                    Id = 44,
                    ClanId = 4,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 11, 13)
                },
                new UplataClanarine
                {
                    Id = 45,
                    ClanId = 5,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 11, 13)
                },
                 new UplataClanarine
                 {
                     Id = 46,
                     ClanId = 6,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 11, 15)
                 },
                 new UplataClanarine
                 {
                     Id = 47,
                     ClanId = 7,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 11, 18)
                 },
                 new UplataClanarine
                 {
                     Id = 48,
                     ClanId = 8,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 11, 20)
                 },
                 new UplataClanarine
                 {
                     Id = 49,
                     ClanId = 9,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 11, 21)
                 },
                 new UplataClanarine
                 {
                     Id = 50,
                     ClanId = 10,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 11, 23)
                 },
                 new UplataClanarine
                 {
                     Id = 51,
                     ClanId = 1,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 12, 8)
                 },
                new UplataClanarine
                {
                    Id = 52,
                    ClanId = 2,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 12, 10)
                },
                new UplataClanarine
                {
                    Id = 53,
                    ClanId = 3,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 12, 12)
                },
                new UplataClanarine
                {
                    Id = 54,
                    ClanId = 4,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 12, 13)
                },
                new UplataClanarine
                {
                    Id = 55,
                    ClanId = 5,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2020, 12, 13)
                },
                 new UplataClanarine
                 {
                     Id = 56,
                     ClanId = 6,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 12, 15)
                 },
                 new UplataClanarine
                 {
                     Id = 57,
                     ClanId = 7,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 12, 18)
                 },
                 new UplataClanarine
                 {
                     Id = 58,
                     ClanId = 8,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 12, 20)
                 },
                 new UplataClanarine
                 {
                     Id = 59,
                     ClanId = 9,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2020, 12, 21)
                 },
                 new UplataClanarine
                 {
                     Id = 60,
                     ClanId = 10,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 1, 23)
                 },
                 new UplataClanarine
                 {
                     Id = 61,
                     ClanId = 1,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 1, 8)
                 },
                new UplataClanarine
                {
                    Id = 62,
                    ClanId = 2,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 1, 10)
                },
                new UplataClanarine
                {
                    Id = 63,
                    ClanId = 3,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 1, 12)
                },
                new UplataClanarine
                {
                    Id = 64,
                    ClanId = 4,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 1, 13)
                },
                new UplataClanarine
                {
                    Id = 65,
                    ClanId = 5,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 1, 13)
                },
                 new UplataClanarine
                 {
                     Id = 66,
                     ClanId = 6,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 1, 15)
                 },
                 new UplataClanarine
                 {
                     Id = 67,
                     ClanId = 7,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 1, 18)
                 },
                 new UplataClanarine
                 {
                     Id = 68,
                     ClanId = 8,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 1, 20)
                 },
                 new UplataClanarine
                 {
                     Id = 69,
                     ClanId = 9,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 1, 21)
                 },
                 new UplataClanarine
                 {
                     Id = 70,
                     ClanId = 10,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 1, 23)
                 },
                 new UplataClanarine
                 {
                     Id = 71,
                     ClanId = 1,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 2, 8)
                 },
                new UplataClanarine
                {
                    Id = 72,
                    ClanId = 2,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 2, 10)
                },
                new UplataClanarine
                {
                    Id = 73,
                    ClanId = 3,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 2, 12)
                },
                new UplataClanarine
                {
                    Id = 74,
                    ClanId = 4,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 2, 13)
                },
                new UplataClanarine
                {
                    Id = 75,
                    ClanId = 5,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 2, 13)
                },
                 new UplataClanarine
                 {
                     Id = 76,
                     ClanId = 6,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 2, 15)
                 },
                 new UplataClanarine
                 {
                     Id = 77,
                     ClanId = 7,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 2, 18)
                 },
                 new UplataClanarine
                 {
                     Id = 78,
                     ClanId = 8,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 2, 20)
                 },
                 new UplataClanarine
                 {
                     Id = 79,
                     ClanId = 9,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 2, 21)
                 },
                 new UplataClanarine
                 {
                     Id = 80,
                     ClanId = 10,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 2, 23)
                 },
                 new UplataClanarine
                 {
                     Id = 81,
                     ClanId = 1,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 3, 8)
                 },
                new UplataClanarine
                {
                    Id = 82,
                    ClanId = 2,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 3, 10)
                },
                new UplataClanarine
                {
                    Id = 83,
                    ClanId = 3,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 3, 12)
                },
                new UplataClanarine
                {
                    Id = 84,
                    ClanId = 4,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 3, 13)
                },
                new UplataClanarine
                {
                    Id = 85,
                    ClanId = 5,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 3, 13)
                },
                 new UplataClanarine
                 {
                     Id = 86,
                     ClanId = 6,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 3, 15)
                 },
                 new UplataClanarine
                 {
                     Id = 87,
                     ClanId = 7,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 3, 18)
                 },
                 new UplataClanarine
                 {
                     Id = 88,
                     ClanId = 8,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 3, 20)
                 },
                 new UplataClanarine
                 {
                     Id = 89,
                     ClanId = 9,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 3, 21)
                 },
                 new UplataClanarine
                 {
                     Id = 90,
                     ClanId = 10,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 3, 23)
                 },
                 new UplataClanarine
                 {
                     Id = 91,
                     ClanId = 1,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 4, 8)
                 },
                new UplataClanarine
                {
                    Id = 92,
                    ClanId = 2,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 4, 10)
                },
                new UplataClanarine
                {
                    Id = 93,
                    ClanId = 3,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 4, 12)
                },
                new UplataClanarine
                {
                    Id = 94,
                    ClanId = 4,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 4, 13)
                },
                new UplataClanarine
                {
                    Id = 95,
                    ClanId = 5,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 4, 13)
                },
                 new UplataClanarine
                 {
                     Id = 96,
                     ClanId = 6,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 4, 15)
                 },
                 new UplataClanarine
                 {
                     Id = 97,
                     ClanId = 7,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 4, 18)
                 },
                 new UplataClanarine
                 {
                     Id = 98,
                     ClanId = 8,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 4, 20)
                 },
                 new UplataClanarine
                 {
                     Id = 99,
                     ClanId = 9,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 4, 21)
                 },
                 new UplataClanarine
                 {
                     Id = 100,
                     ClanId = 10,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 4, 23)
                 },
                 new UplataClanarine
                 {
                     Id = 101,
                     ClanId = 1,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 5, 8)
                 },
                new UplataClanarine
                {
                    Id = 102,
                    ClanId = 2,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 5, 10)
                },
                new UplataClanarine
                {
                    Id = 103,
                    ClanId = 3,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 5, 12)
                },
                new UplataClanarine
                {
                    Id = 104,
                    ClanId = 4,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 5, 13)
                },
                new UplataClanarine
                {
                    Id = 105,
                    ClanId = 5,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 5, 13)
                },
                 new UplataClanarine
                 {
                     Id = 106,
                     ClanId = 6,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 5, 15)
                 },
                 new UplataClanarine
                 {
                     Id = 107,
                     ClanId = 7,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 5, 18)
                 },
                 new UplataClanarine
                 {
                     Id = 108,
                     ClanId = 8,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 5, 20)
                 },
                 new UplataClanarine
                 {
                     Id = 109,
                     ClanId = 9,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 5, 21)
                 },
                 new UplataClanarine
                 {
                     Id = 110,
                     ClanId = 10,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 5, 23)
                 },
                 new UplataClanarine
                 {
                     Id = 111,
                     ClanId = 1,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 6, 8)
                 },
                new UplataClanarine
                {
                    Id = 112,
                    ClanId = 2,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 6, 10)
                },
                new UplataClanarine
                {
                    Id = 113,
                    ClanId = 3,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 6, 12)
                },
                new UplataClanarine
                {
                    Id = 114,
                    ClanId = 4,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 6, 13)
                },
                new UplataClanarine
                {
                    Id = 115,
                    ClanId = 5,
                    Iznos = 10,
                    Opis = "Uplata članarine",
                    DatumUplacivanja = new DateTime(2021, 6, 13)
                },
                 new UplataClanarine
                 {
                     Id = 116,
                     ClanId = 6,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 6, 15)
                 },
                 new UplataClanarine
                 {
                     Id = 117,
                     ClanId = 7,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 6, 18)
                 },
                 new UplataClanarine
                 {
                     Id = 118,
                     ClanId = 8,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 6, 20)
                 },
                 new UplataClanarine
                 {
                     Id = 119,
                     ClanId = 9,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 6, 21)
                 },
                 new UplataClanarine
                 {
                     Id = 120,
                     ClanId = 10,
                     Iznos = 10,
                     Opis = "Uplata članarine",
                     DatumUplacivanja = new DateTime(2021, 6, 23)
                 }
                );

            #endregion
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}

using Newsfeed.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsfeed.Common.Repositories
{
    public static class MockRepository
    {
        public static Author GetAuthor(string name) {
            var author = new Author
            {
                Name = name,
                SessionId = null
            };
            return author;
        }

        public static List<Status> GetStatuses(Author author)
        {
            var indices = GetNonRepeatingRandomNumbers(0, MockStatuses.Count - 1, 10);
            var statuses = new List<Status>();

            foreach (var i in indices)
            {
                statuses.Add(new Status
                {
                    Author = author,
                    Text = MockStatuses[i],
                    Timestamp = DateTime.Now.AddDays(-i).AddHours(-i).AddMinutes(-i)
                });
            }

            return statuses;
        }

        private static List<String> MockStatuses = new List<String>() {
            "Cinema is the ultimate pervert art. It doesn't give you what you desire - it tells you how to desire.",
            "The one measure of true love is: you can insult the other",
            "Words are never 'only words'; they matter because they define the contours of what we can do.",
            "We feel free because we lack the very language to articulate our unfreedom.",
            "The problem for us is not are our desires satisfied or not. The problem is how do we know what we desire.",
            "We like to be guilty since, if we are guilty, it all depends on us.",
            "What is really hard is to accept is that we are reduced to the role of a passive observer who sits and watches what our fate will be.",
            "We recycle paper, we buy organic food, we install long-lasting light bulbs—whatever—just so we can be sure that we are doing something.",
            "Love feels like a great misfortune, a monstrous parasite, a permanent state of emergency that ruins all small pleasures.",
            "Because the horror of Communism, Stalinism, is not that bad people do bad things — they always do.",
            "If you have reasons to love someone, you don’t love them.",
            "Nowadays, you can do anything that you want—anal, oral, fisting—but you need to be wearing gloves, condoms, protection.",
            "As soon as we renounce fiction and illusion, we lose reality itself.",
            "The moment we subtract fictions from reality, reality itself loses its discursive-logical consistency.",
            "Humanity is OK, but 99% of people are boring idiots.",
            "I am a good Hegelian. If you have a good theory, forget about the reality.",
            "Come on. I don't have any problem violating my own insights in practice.",
            "You know how Scotland began? One of us Slovenians was spending too much money, so we put him on a boat and he landed in Scotland.",
            "Same rightists who decades ago were shouting 'Better dead than red!' are now often heard mumbling 'Better red than eating hamburgers.'",
            "Beyond the fiction of reality, there is the reality of the fiction.",
            "In contrast to the situation in 1945, the world does not need the US; it is the US that needs the rest of the world.",
            "We’re not dreamers. We’re awaking from a dream into a nightmare. We’re not destroying. We’re watching the system destroy itself.",
            "It's not the same thing: coffee without cream or coffee without milk. What you don't get is part of the identity of what you get.",
            "Ideology is strong exactly because it is no longer experienced as ideology.",
            "In other words, who dares to strike today,when having the security of a permanent job is itself becoming a privilege?",
            "Ultimately, we hear things because we cannot see everything.",
            "True power does not need arrogance, a long beard and a barking voice.",
            "True power strangles you with silk ribbons, charm, and intelligence.",
            "There is a wonderful expression, war nam nihadan, which means to murder somebody, bury his body, then grow flowers over the body.",
            "When I really love someone, I can only show it by making aggressive and bad-taste remarks.",
            "This is the paradox of public space: even if everyone knows an unpleasant fact, saying it in public changes everything.",
            "There too the target was the entire functioning of the state apparatuses of power.",
            "And there can be no friendship with someone whom I am not ready to betray: a friend is someone I can betray with love.",
            "What makes us happy is not to get what we want. But to dream about it.",
            "So I think that the only life of deep satisfaction is a life of eternal struggle, especially struggle with oneself.",
            "If you want to remain happy, just remain stupid. Authentic masters are never happy; happiness is a category of slaves.",
            "Does everything that exists have to be grounded in sufficient reasons? Or are there things that somehow happen out of nowhere?",
            "What one should add here is that self-consciousness is itself unconscious: we are not aware of the point of our self-consciousness.",
            "It is then a supreme irony that traces of this same fetishizing procedure can be found in Adorno's own writings.",
            "Recall the famous line from Dialectic of Englightment on how Hollywood's ideological manipulation of social reality...",
            "This unintended self-reflexivity is something of which Adorno undoubtedly was not aware.",
            "For Lacan, exactly the same description holds for desire, which is why enjoyment is not something that comes naturally to the subject.",
            "Postcolonialism is the invention of rich Indian guys who wanted to make a career in the west by playing on the guilt of white liberals.",
            "What about the apparent absurdity of the idea of dignity, freedom, and reason, sustained by extreme military discipline...",
            "We can understand an attempt to ignore power as being just for the right of the people when conditions demand it.",
            "The state functions only as far as it is recognized as functioning. People have tremendous power in organizing themselves to ignore power.",
            "Sexuality is the only drive that is in itself hindered, perverted: simultaneously insufficient and excessive...",
            "How much energy is discharged when two bodies collide?",
            "The universal surplus–this capacity of sexuality to overflow the entire field of human experience... is not the sign of preponderance.",
            "Without communist oppression, I am absolutely sure I would now be a local stupid professor of philosophy in Ljubljana.",
            "The task of philosophy is not to provide answers, but to show how the way we perceive a problem can be itself part of a problem.",
            "An enemy is someone whose story you have not heard.",
            "I do all my work to escape myself. I don't believe in looking into yourself. If you do this, you just discover a lot of shit.",
            "I think what we should do is throw ourselves out of ourselves. The truth is not deep in ourselves. The truth is outside.",
            "The proper way for the woman to test the man’s love is thus to betray him at a crucial moment in his career.",
            "Art is not just a heightened procedure of providing sensual pleasures, but a medium of Truth.",
            "Let’s think about the fake sense of urgency that pervades the left-liberal humanitarian discourse on violence.",
            "There is a fundamental anti-theoretical edge to these urgent injunctions.",
            "There is no time to reflect: we have to act now.",
            "Marx’s letter conveys his sheer panic: can’t the revolution wait for a couple of years? He hasn’t yet finished his ‘Capital’.",
            "The limitation of the standard liberal attitude towards Muslim women wearing a veil is visible here, too.",
            "Women are permitted to wear the veil if this is their free choice and not an option imposed on them by their husbands or family.",
            "It is no longer a sign of belonging to the Muslim community, but an expression of their idiosyncratic individuality.",
            "This is why, in our secular, choice-based societies, people who maintain a substantial religious belonging are in a subordinate position.",
            "Even if they are allowed to maintain their belief, their belief is 'tolerated'' as their idiosyncratic personal choice or opinion.",
            "The moment they present it publicly as what it is for them, say a matter of substantial belonging, they are accused of fundamentalism.",
            "It would be interesting to compare Tarkovsky’s work with Hollywood commercial rewritings of novels which have served as bases for movies.",
            "We don't really want to get what we think that we want.",
            "I am married to a wife and relationship with her are cold and I have a mistress.",
            "I'm not a murderer but let us say - that it will open up a new life with the mistress.",
            "Then, for some reason, the wife goes away, you lose the mistress.",
            "You thought this is all I want, when you have it there, you turn out it was a much more complex situation.",
            "It was not to live with the mistress, but to keep her as a distance as on object of desire about which you dream.",
            "This is not an excessive example, I claim this is how things function. We don't really want what we think we desire.",
            "You cannot change people but you can change the system so that people are not pushed into doing evil things.",
            "I believe this may be the main task for today: to prevent the narrow production of experts.",
            "We need, more than ever, those who, in a general way of thinking, see the problems from a global perspective.",
            "You cannot change people but you can change the system so that people are not pushed into doing evil things.",
            "I am an anti-capitalist because I believe we can improve on it.",
            "Settle disputes diplomatically, and when necessary, quash disputes militarily with proportional measure.",
            "In short, the ultimate source of Evil is compasion itself.",
            "What characterizes a really great thinker is that they misrecognize the basic dimension of their own breakthrough."
        };


        private static List<int> GetNonRepeatingRandomNumbers(int SmallestNumber, int LargestNumber, int HowManyDoYouNeed)
        {
            if (LargestNumber - SmallestNumber < HowManyDoYouNeed)
                throw new Exception("Nope.");
            
            var numbers = new List<int>();
            var ran = new Random();
            
            var number = ran.Next(SmallestNumber, LargestNumber);
            if (!numbers.Any(i => i == number))
                numbers.Add(number);
            
            return numbers;
        }



    }
}

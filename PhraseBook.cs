using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechTranslator
{
    class PhraseBook
    {
        string[] itaSentences = new string[] {
                "Ciao, come ti chiami?",
                "Oggi è una bella giornata",
                "Siamo andati a comprare il pane",
                "Il gatto ha dormito per tutto il pomeriggio.",
            };

        string[] engSentences = new string[] {
                "Hello, what's your name?",
                "Today is a nice day",
                "We went to buy bread",
                "The cat took a nap from one to three in the afternoon.",
                "Once upon a time, there was a little town called Redmond",
            };

        Dictionary<string, string[]> sentences = new Dictionary<string, string[]>();
        Random random;

        public PhraseBook()
        {
            
            this.sentences["en-US"] = engSentences;
            this.sentences["it-IT"] = itaSentences;

            this.random = new Random();
        }

        public string[] GetPhrases(string language)
        {
            if (sentences.ContainsKey(language))
            {
                return sentences[language];
            }
            else
                return null;
        }

        public string GetPhrase(string language)
        {
            if (sentences.ContainsKey(language))
            {
                int count = sentences[language].Length;
                int index = random.Next(count);
                return sentences[language][index];
            }
            else
                return "Hello, world";
        }

    }
}

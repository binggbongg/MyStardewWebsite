using MyWebsite.Models;

namespace MyWebsite.Services;

public class QuizDataService
{
    public List<Question> GetQuestions()
    {
        return new List<Question>
        {
            // Question 1
            new Question
            {
                Id = 1,
                QuestionItem = "It is a rainy Tuesday afternoon. Where would anyone most likely find you?",
                Options = new List<QuizOption>
                {
                    new QuizOption
                    {
                        Text = "Curled up in bed with a good fantasy novel or sketchpad.",
                        CharacterWeights = new() { { "Haley", 3 }, { "Leah", 3 }, { "Penny", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "In a quiet basement tinkering with electronics or playing video games.",
                        CharacterWeights = new() { { "Sebastian", 3 }, { "Maru", 3 }, { "Abigail", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "At the local café or pub sharing stories with regulars.",
                        CharacterWeights = new() { { "Shane", 3 }, { "Emily", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "Out in the woods or wandering the beach, enjoying the quiet storm.",
                        CharacterWeights = new() { { "Alex", 2 }, { "Elliot", 1 } }
                    }
                }
            },

            // Question 2
            new Question
            {
                Id = 2,
                QuestionItem = "What type of gift makes you light up the most?",
                Options = new List<QuizOption>
                {
                    new QuizOption
                    {
                        Text = "Something hand-crafted, grown, or gathered from nature.",
                        CharacterWeights = new() { { "Leah", 3 }, { "Elliot", 2 }, { "Emily", 2 }, { "Haley", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "A rare gemstone, fossil, or ancient relic.",
                        CharacterWeights = new() { { "Abigail", 3 }, { "Penny", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "A gourmet homemade meal or premium brew.",
                        CharacterWeights = new() { { "Shane", 3 }, { "Harvey", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "Something practical, high-tech, or neatly organized.",
                        CharacterWeights = new() { { "Maru", 3 }, { "Sebastian", 1 } }
                    },
                    new QuizOption
                    {
                        Text = "A stylish accessory or designer item.",
                        CharacterWeights = new() { { "Haley", 2 }, { "Elliott", 2 }, { "Emily", 1 } }
                    }
                }
            },

            // Question 3
            new Question
            {
                Id = 3,
                QuestionItem = "What is your ideal weekend activity?",
                Options = new List<QuizOption>
                {
                    new QuizOption
                    {
                        Text = "Playing sports, working out, or spending the day active outside.",
                        CharacterWeights = new() { { "Alex", 3 }, { "Sam", 1 } }
                    },
                    new QuizOption
                    {
                        Text = "Going foraging, bird-watching, or tending a quiet garden.",
                        CharacterWeights = new() { { "Leah", 3 }, { "Alex", 1 }, { "Penny", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "Stargazing through a telescope or reading obscure articles.",
                        CharacterWeights = new() { { "Maru", 3 }, { "Harvey", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "Playing music, jamming with friends, or gaming.",
                        CharacterWeights = new() { { "Sam", 3 }, { "Sebastian", 2 }, { "Abigail", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "Browsing boutique shops or taking aesthetic photos outdoors.",
                        CharacterWeights = new() { { "Haley", 3 }, { "Elliott", 2 } }
                    }
                }
            },

            // Question 4
            new Question
            {
                Id = 4,
                QuestionItem = "How do you handle social gatherings?",
                Options = new List<QuizOption>
                {
                    new QuizOption
                    {
                        Text = "I stay near the snacks or slip out early to get back to my comfort zone.",
                        CharacterWeights = new() { { "Sebastian", 3 }, { "Shane", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "I'm the life of the party, dancing or making sure everyone is having fun.",
                        CharacterWeights = new() { { "Emily", 3 }, { "Sam", 2 }, { "Alex", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "I prefer finding one or two people for a deep, genuine conversation.",
                        CharacterWeights = new() { { "Penny", 3 }, { "Harvey", 2 }, { "Elliott", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "I'm comfortable observing quietly from the edge of the room.",
                        CharacterWeights = new() { { "Linus", 3 }, { "Leah", 2 }, { "Maru", 1 } }
                    }
                }
            },

            // Question 5
            new Question
            {
                Id = 5,
                QuestionItem = "What is your go-to comfort meal when you've had a long day?",
                Options = new List<QuizOption>
                {
                    new QuizOption
                    {
                        Text = "Spicy curry or a slice of warm pepperoni pizza.",
                        CharacterWeights = new() { { "Shane", 3 }, { "Sam", 2 }, { "Abigail", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "A fresh salad with goat cheese and wild berries.",
                        CharacterWeights = new() { { "Leah", 3 }, { "Haley", 2 }, { "Shane", 1 } }
                    },
                    new QuizOption
                    {
                        Text = "A warm, hearty home-cooked soup or stew.",
                        CharacterWeights = new() { { "Penny", 3 }, { "Emily", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "A strong cup of fresh black coffee and a small pastry.",
                        CharacterWeights = new() { { "Harvey", 3 }, { "Sebastian", 2 } }
                    }
                }
            },

            // Question 6
            new Question
            {
                Id = 6,
                QuestionItem = "Which season do you feel most inspired or energized in?",
                Options = new List<QuizOption>
                {
                    new QuizOption
                    {
                        Text = "Spring. everything is blooming and bursting with fresh potential.",
                        CharacterWeights = new() { { "Penny", 3 }, { "Maru", 2 }, { "Emily", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "Summer. warm beach days, high energy, and outdoor fun.",
                        CharacterWeights = new() { { "Alex", 3 }, { "Haley", 3 }, { "Sam", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "Fall. pumpkin patches, cozy sweaters, and misty afternoons.",
                        CharacterWeights = new() { { "Abigail", 3 }, { "Leah", 3 }, { "Elliott", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "Winter. crisp cold air, quiet nights, and peaceful snowfall.",
                        CharacterWeights = new() { { "Sebastian", 3 }, { "Linus", 2 }, { "Harvey", 2 } }
                    }
                }
            },

            // Question 7
            new Question
            {
                Id = 7,
                QuestionItem = "If you could live in any house design, what would it look like?",
                Options = new List<QuizOption>
                {
                    new QuizOption
                    {
                        Text = "A cozy log cabin hidden deep in the forest.",
                        CharacterWeights = new() { { "Leah", 3 }, { "Elliot", 1 } }
                    },
                    new QuizOption
                    {
                        Text = "A sleek modern loft filled with gadgets and smart workstations.",
                        CharacterWeights = new() { { "Maru", 3 }, { "Sebastian", 1 } }
                    },
                    new QuizOption
                    {
                        Text = "An eccentric cottage with crystals, hanging plants, and a sewing corner.",
                        CharacterWeights = new() { { "Emily", 3 }, { "Abigail", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "A seaside shack right on the dock overlooking the ocean waves.",
                        CharacterWeights = new() { { "Elliott", 3 }, { "Haley", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "A classic, tidy home with a flower garden and bookshelf wall.",
                        CharacterWeights = new() { { "Penny", 3 }, { "Harvey", 2 } }
                    }
                }
            },

            // Question 8
            new Question
            {
                Id = 8,
                QuestionItem = "When a friend is going through a tough time, how do you support them?",
                Options = new List<QuizOption>
                {
                    new QuizOption
                    {
                        Text = "Sitting quietly beside them so they don't have to be alone.",
                        CharacterWeights = new() { { "Sebastian", 2 }, { "Shane", 3 }, { "Haley", 1 } }
                    },
                    new QuizOption
                    {
                        Text = "Giving them practical advice, remedies, or a step-by-step plan.",
                        CharacterWeights = new() { { "Harvey", 3 }, { "Maru", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "Distracting them with games, humor, or a high-energy outing.",
                        CharacterWeights = new() { { "Sam", 3 }, { "Alex", 2 }, { "Abigail", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "Cooking them a warm meal or writing a heartfelt note.",
                        CharacterWeights = new() { { "Penny", 3 }, { "Leah", 2 }, { "Emily", 2 }, { "Haley", 2 } }
                    }
                }
            },

            // Question 9
            new Question
            {
                Id = 9,
                QuestionItem = "What is your biggest personal ambition?",
                Options = new List<QuizOption>
                {
                    new QuizOption
                    {
                        Text = "Mastering a creative craft, art form, or novel.",
                        CharacterWeights = new() { { "Leah", 3 }, { "Elliott", 3 } }
                    },
                    new QuizOption
                    {
                        Text = "Advancing science, medicine, or technological discovery.",
                        CharacterWeights = new() { { "Maru", 3 }, { "Harvey", 3 } }
                    },
                    new QuizOption
                    {
                        Text = "Living simply, in harmony with nature and free from modern stress.",
                        CharacterWeights = new() { { "Elliot", 2 }, { "Shane", 1 }, { "Leah", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "Finding genuine inner peace and helping the people around me thrive.",
                        CharacterWeights = new() { { "Penny", 3 }, { "Emily", 3 } }
                    },
                    new QuizOption
                    {
                        Text = "Achieving athletic greatness or standing out from the crowd.",
                        CharacterWeights = new() { { "Alex", 3 }, { "Haley", 2 } }
                    }
                }
            },

            // Question 10
            new Question
            {
                Id = 10,
                QuestionItem = "Pick an adventure:",
                Options = new List<QuizOption>
                {
                    new QuizOption
                    {
                        Text = "Delving deep into a dark cave searching for hidden minerals and monsters.",
                        CharacterWeights = new() { { "Abigail", 3 }, { "Sebastian", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "Taking a wooden sailboat out to a misty island to write and explore.",
                        CharacterWeights = new() { { "Elliott", 3 }, { "Leah", 1 } }
                    },
                    new QuizOption
                    {
                        Text = "Camping under an unpolluted night sky tracking meteor showers.",
                        CharacterWeights = new() { { "Maru", 3 }, { "Harvey", 2 }, { "Shane", 1 } }
                    },
                    new QuizOption
                    {
                        Text = "Organizing a lively local street festival or music gig.",
                        CharacterWeights = new() { { "Sam", 3 }, { "Emily", 2 } }
                    },
                    new QuizOption
                    {
                        Text = "A sunny beach volleyball game followed by a sunset walk.",
                        CharacterWeights = new() { { "Alex", 3 }, { "Haley", 3 } }
                    }
                }
            }
        };
    }
}
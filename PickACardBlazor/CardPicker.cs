namespace PickACardBlazor;

public class CardPicker
{
    public static string[] PickSomeCards(int numberOfCards)
    {
        var pickedCards = new string[numberOfCards];

        for (var i = 0; i < numberOfCards; i++)
            // before adding the new card to array,
            // check if the array already contains the card,
            // in which case pick another random card
            while (true)
            {
                var randCard = RandomValue() + " of " + RandomSuit();
                if (pickedCards.Contains(randCard)) continue;
                pickedCards[i] = randCard;
                break;
            }

        return pickedCards;
    }

    private static string RandomSuit()
    {
        var suits = new[]
        {
            "Spades",
            "Diamonds",
            "Hearts",
            "Clover"
        };

        var rnd = new Random();

        return suits[rnd.Next(suits.Length)];
    }

    private static string RandomValue()
    {
        var values = new List<string>
        {
            "Ace",
            "Jack",
            "Queen",
            "King"
        };

        for (var i = 2; i < 9; i++) values.Add(i.ToString());

        var rnd = new Random();

        return values[rnd.Next(values.Count)];
    }
}
namespace TheSlum.GameEngine
{
    using System;

    public class ExtendedEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                default:
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            Character character;

            switch (inputParams[1])
            {
                case "warrior":
                    character = new Warrior(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        (Team)Enum.Parse(typeof(Team), inputParams[5], true)); // convert string to enum
                    break;
                case "mage":
                    character = new Mage(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        (Team)Enum.Parse(typeof(Team), inputParams[5], true));
                    break;
                case "healer":
                    character = new Healer(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        (Team)Enum.Parse(typeof(Team), inputParams[5], true));
                    break;
                default:
                    throw new ApplicationException("This character doesn't exist!");
            }

            this.characterList.Add(character);
        }

        protected new void AddItem(string[] inputParams)
        {
            Item item;

            switch (inputParams[2])
            {
                case "axe":
                    item = new Axe(inputParams[3]);
                    break;
                case "shield":
                    item = new Shield(inputParams[3]);
                    break;
                case "injection":
                    item = new Injection(inputParams[3]);
                    break;
                case "pill":
                    item = new Pill(inputParams[3]);
                    break;
                default:
                    throw new ApplicationException("This item doesn't exist!");
            }

            Character character = GetCharacterById(inputParams[1]);

            character.AddToInventory(item);
        }
    }
}
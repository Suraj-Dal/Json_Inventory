var log = NLog.LogManager.GetCurrentClassLogger();
log.Warn("Enter choice in integer only.");
Console.WriteLine("Which JSON you want to view:\n1.Inventoy Management\n2.Stock Account");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        log.Info("json for Inventory Management");
        jsonInventory.jsonInventoryMain json = new jsonInventory.jsonInventoryMain();
        json.convert(@"D:\Suraj\Projects\Json_Inventory\jsonInventory\jsonInventory\Inventory.json");
        break;
    case 2:
        log.Info("Json for Stock Account");
        jsonInventory.jsonPortfolioMain stock = new jsonInventory.jsonPortfolioMain();
        stock.convert(@"D:\Suraj\Projects\Json_Inventory\jsonInventory\jsonInventory\jsonPortfolio.json");
        break;
    default:
        Console.WriteLine("Invalid choice:");
        break;
}

        
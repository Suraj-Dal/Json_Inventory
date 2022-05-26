
jsonInventory.jsonInventoryMain json = new jsonInventory.jsonInventoryMain();
var log = NLog.LogManager.GetCurrentClassLogger();
log.Info("Inventory Management has started");
json.convert(@"D:\Suraj\Projects\Json_Inventory\jsonInventory\jsonInventory\Inventory.json");
        
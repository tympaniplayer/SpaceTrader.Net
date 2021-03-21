namespace SpaceTrader.Net.RequestModels.PurchaseOrder
{
    public class PlacePurchaseOrderRequest : AuthenticatedRequest, IRequest
    {
       public string Username { get; set; } 
       public string ShipId { get; set; }
       public string Good { get; set; }
       public int Quantity { get; set; }

       public string BuildRoute()
       {
           return $"users/{Username}/purchase-orders";
       }
    }
}
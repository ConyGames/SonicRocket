[System.Serializable]
public class ShipData{
    public float InitialShipSpeed;
    public float ShipSideMove;
    public float ShipAccelarationFactor;

    public ShipData(float InitialShipSpeed, float ShipSideMove){
        this.InitialShipSpeed = InitialShipSpeed;
        this.ShipSideMove = ShipSideMove;
    }
    
}
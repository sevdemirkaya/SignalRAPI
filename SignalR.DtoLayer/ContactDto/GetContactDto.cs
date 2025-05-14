namespace SignalR.DtoLayer.ContactDto
{
    public class GetContactDto
    {
        public int ContactID { get; set; }
        public string Location { get; set; }

        public int Phone { get; set; }
        public string Mail { get; set; }
        public string FooterDescription { get; set; }
    }
}

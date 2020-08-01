namespace PaymentGatewayAPI
{
  public  class ConnectionException:BaseException
    {
        public ConnectionException(string message)
			: base(message)
        { }
    }
}

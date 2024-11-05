namespace Tut5_s20123.Factory
{
    public interface IDatabase
    {
        void Connect();
        void ExecuteQuery(string query);
    }

}

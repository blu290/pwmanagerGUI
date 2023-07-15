public class PWEntry
{
    public int ID = -1;
    public int UserID = -1;
    public string ServiceName = "";
    public string Username = "";
    public string Password = "";

    public PWEntry(int id, int userid, string servicename, string username, string password)
    {
        ID = id;
        UserID = userid;
        ServiceName = servicename;
        Username = username;
        Password = password;
    }
    public PWEntry()
    {

    }
    public int getUserID() { return ID; }
    public int getID() { return ID; }
    public string getServiceName() { return ServiceName; }
    public string getUserName() { return Username; }
    public string getPassword() { return Password; }
    public string getDecryptedPassword(byte[] key)
    {
        return CryptoHelper.decryptString(Password, key);
    }
    public void setUserID(int id) { ID = id; }
    public void setServiceName(string servicename) { ServiceName = servicename; }
    public void setUserName(string username) { Username = username; }
    public void setPassword(string password) { Password = password; }

}


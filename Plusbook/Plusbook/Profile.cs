using System;

public class Profile
{
	private string name;
	private FriendList* friends_list;

	public Profile()
	{
	}
	public Profile(string)
	{
	}
	public Profile(const Profile&)
	{
	}
	public Profile& operator=(const Profile&)
	{
	}
	public ~Profile()
	{
	}

	public string getName() { }
	public void setName() { }
	public FriendList getFriendList() { }

	public void addFriend(Profile*) { }
}

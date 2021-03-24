using System;
using System.Collections.Generic;

public class Profile
{
	private string name;
	private List<Profile> friends_list;

	public Profile()
	{
		this.name = "Dummy";
		this.friends_list = new List<Profile>();
	}
	public Profile(string Name)
	{
		this.name = Name;
		this.friends_list = new List<Profile>();
	}
	public Profile(Profile Other)
	{
		this.name = Other.name;
		this.friends_list = new List<Profile>();
		foreach (var Prof in Other.friends_list) {
			this.friends_list.Add(Prof);
		}
	}
	public Profile copy()
	{
		Profile P2 = new Profile(this.name);
		P2.friends_list = this.getFriendList();

		return P2;
	}
	
	public string getName() { return this.name; }
	public List<Profile> getFriendList()
	{
		List<Profile> newFriends = new List<Profile>();

		foreach (var Prof in this.friends_list) {
			newFriends.Add(Prof);
		}

		return newFriends;
	}
	public void setName(string Name) { this.name = Name; }

	public void addFriend(Profile NewFriend) 
	{
		this.friends_list.Add(NewFriend);
	}

	public bool isFriendsWith(string Name)
	{
		for (int i = 0; i < this.friends_list.Count; i++) {
			if (this.friends_list[i].name == Name) {
				return true;
			}
		}

		return false;
	}
}

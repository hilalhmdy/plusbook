using System;
using System.Collections.Generic;

public class ProfileList
{
	private List<Profile> profiles;
	
	public ProfileList()
	{
		this.profiles = new List<Profile>();
	}
	public ProfileList(ProfileList Other)
	{
		this.profiles = new List<Profile>();
		foreach (var Prof in Other.profiles) {
			this.profiles.Add(Prof);
		}
	}

	public void addProfile(string Name)
	{
		Profile newProfile = new Profile(Name);
		this.profiles.Add(newProfile);
	}
	public bool isExist(string Name)
	{
		for (int i = 0; i < this.profiles.Count; i++) {
			if (this.profiles[i].getName() == Name) {
				return true;
			}
		}

		return false;
	}
	public Profile getProfile(string Name) 
	{
		for (int i = 0; i < this.profiles.Count; i++) {
			if (this.profiles[i].getName() == Name)
			{
				return this.profiles[i];
			}
		}

		return new Profile();
	}
	public void addConnection(string A, string B)
	{
		Profile ProfA, ProfB;

		if (!this.isExist(A)) {
			ProfA = new Profile(A);
			this.profiles.Add(ProfA);
		}
		if (!this.isExist(B)) {
			ProfB = new Profile(B);
			this.profiles.Add(ProfB);
		}

		ProfA = this.getProfile(A);
		ProfB = this.getProfile(B);
		if (!ProfA.isFriendsWith(B)) {
			ProfA.addFriend(ProfB);
		}
		if (!ProfB.isFriendsWith(A)) {
			ProfB.addFriend(ProfA);
		}
	}
}
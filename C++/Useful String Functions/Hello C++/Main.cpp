#include <iostream>
#include <string>

using namespace std;

int main() 
{
	// string.length() returns length of a string
	// string.empty() returns true if empty
	// string.clear() clears a string
	// string1.append(string2) appends astring
	// string1.at(x) returns a charater at a given index
	// string1.substr(int x, int y) retruece a portion of string 
 	// string1.insert(int x, string2); Insert a string with 
	// string1.find(string2); returns index of string2
	// string1.erase(x,y) erases portion of a string
	
	string first_name;
	string user_name;

	cout << "Enter your first name: " << endl;
	getline(cin, first_name);

	cout << "Enter your user name: ";
	getline(cin, user_name);

	if (first_name.length() >= 12) {
		cout << "Your name cant be over 12 characters " << endl;
	}
	else if (first_name.empty()) {
		cout << "You didnt enter a name! " << endl;
	}
	else {
		cout << "Welcome " << first_name;
	}

	cout << "\nYour name has been cleared" << endl;
	first_name.clear();
	cout << "\nWelcome " << first_name;
	
	string email = user_name.append("@gmail.com");
	cout << "Your email is now: " << email << endl;


	string firstname;
	string midname;
	string lastname;

	cout << "First name: ";
	getline(cin, firstname);
	cout << "Mid name: ";
	getline(cin, midname);
	cout << "Last name: ";
	getline(cin, lastname);

	char letter1 = firstname.at(0);
	char letter2 = midname.at(0);
	char letter3 = lastname.at(0);
	cout << "Your initials are: " << letter1 << letter2 << letter3;
	
	cout << "\nYour full name is: " << firstname << midname << lastname; 



	string name;
	cout << "\nName: ";
	getline(cin, name);

	string nickname = name.substr(3, 5);

	cout << "\nYour nickname is: " << nickname << endl;
	cout << "\n Hello " << nickname;



	string okname;
	cout << "\nEnter your okname: ";
	getline(cin, okname);

	okname.insert(3, "OKOK@@@@");

	cout << "\nReply" << okname;


	string yesname;
	cout << "\nEnter your yes name: ";
	getline(cin, yesname);

	string substring;
	cout << "\nSearch for which character/s?: ";
	getline(cin, substring);

	int possition = yesname.find(substring);

	cout << "\nFound character/s at position: " << possition;
	

	string phonenumber;
	cout << "\nEnter your phone number: ";
	getline(cin, phonenumber);

	phonenumber.erase(0,4);

	cout << "\nPhoneNumber: " << phonenumber;



	cout << endl;
	return 0;
}
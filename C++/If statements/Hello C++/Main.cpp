#include <iostream>

using namespace std;
int main() 
{
	int age;
	cout << " How old are you? ";
	cin >> age;
	cout << " Your age is: " << age;

	cout << endl;

	if (age == 18) {
		cout << "OK You are 18 years old" << endl;
	}
	
	//else if (age != 18) {
	//	cout << "OK You are not 18 years old";
	//}

	else if (age >= 18) {
		cout << "OK You are adult" << endl;
	}
	else {
		cout << "OK You are a young" << endl;
	}
	cout << endl;




	return 0;
}
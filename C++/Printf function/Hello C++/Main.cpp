#include <iostream>
#include <string>
#include <algorithm>

using namespace std;
int main() 
{
	// printf()
	
	string make = "1";
	string mode = "2";
	int year = 2022;
	double price = 9999.000;
	char forsale = 'Y';

	printf("Your car is made by: %s", "1"); // %[flags][width][.precision][length]specifier
	cout << endl;
	printf("Your car is made by: %s", make.c_str());
	cout << endl;
	printf("Your car is mode and make by: %s %s" , mode.c_str(), make.c_str());
	cout << endl;
	printf("Your car is year by: %d", year);
	cout << endl;
	printf("Your car is price by: %f", price);
	cout << endl;
	printf("Your car is for sale by: %c", forsale);
	cout << endl;

	printf("The price is: %.2f", price);
	cout << endl;
	printf("Blank spaces: %10s", "1"); 
	cout << endl;
	printf("Blank spaces zeros:%010s", "1");
	cout << endl;
	printf("Left jusify spaces zeros:%-10s", "1");
	cout << endl;
	printf("Left jusify spaces zeros:%-10s%-10s", "1","2");
	cout << endl;

	cout << endl;
	return 0;
}
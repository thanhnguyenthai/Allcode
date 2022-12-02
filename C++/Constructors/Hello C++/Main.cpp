#include <iostream>
#include <string>
#include <algorithm>

using namespace std;



class Human {
public:
	string name;
	int age;
	double weight;
	Human(string name, int age, double weight);
		
};

//scope resolution :: operator

Human::Human(string name, int age, double weight) {
	this->name = name;
	this->age = age;
	this->weight = weight;
}

int main() 
{
	// constructor = special function that is automatically called when an object is instantiated
	// useful for assigning argument to variables
	
	Human human1("Rick",65,80);
	Human human2("Winkey", 56,60);
	

	cout << human1.name << endl;
	cout << human1.age << " yo " << endl;
	cout << human1.weight << " KGS " << endl;


	cout << human2.name << endl;
	cout << human2.age << " yo " << endl;
	cout << human2.weight << " KGS " << endl;

	cout << endl;
	return 0;
}
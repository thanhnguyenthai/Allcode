#include <iostream>
#include <string>
#include <algorithm>

using namespace std;
int main()
{
	//int nums[3][4] ={ { 0,1,2,3 },
	//				{ 4,5,6,7 },
	//				{ 8,9,10,11 } 
		//			};

	////cout << nums[2][3];

	//for (int row = 0; row < 3; row++) {
	//	for (int column = 0; column < 4; column++) {
	//		cout << nums[row][column] << " ";
	//	}
	//	cout << endl;
	//}




	//-----------------

	//Project

	char keyboard[4][3] = {
		{'1','2','3'},
		{'A','B','C'},
		{'D','E','F'},
		{'G','H','I'}
	};

	for (int row = 0; row < 4; row++) {
		for (int column = 0; column < 3; column++) {
			cout << keyboard[row][column] << " ";
		}
		cout << endl;
	}


	cout << endl;
	return 0;
}
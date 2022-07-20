#include <iostream>
#include "..\revlib\repeat.h"

#ifndef CATEGORY_H
#define CATEGORY_H

using namespace std;

void newCategory(string catestr, string mainstr, int times, bool newline) {
	if (newline) { cout << "\n"; }
	repeat(catestr, times);
	cout << " " << mainstr << " ";
	repeat(catestr, times);
	if (newline) { cout << "\n\n"; }
}

#endif

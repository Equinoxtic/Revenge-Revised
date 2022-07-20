#include <iostream>
#include "..\revlib\repeat.h"

#ifndef TEXTDIVIDER_H
#define TEXTDIVIDER_H

using namespace std;

void createDivider(string div_char, int times, bool _fnln, bool _snln) {
	if (_fnln) { cout << "\n"; }
	repeat(div_char, times);
	if (_snln) { cout << "\n"; }
}

#endif

#include <iostream>

#ifndef REPEAT_H
#define REPEAT_H

using namespace std;

void repeat(string a, int times) {
	for(int i = 0; i < times; i++) { cout << a; }
}

void tab_repeat(int a) {
	for(int i = 0; i < a; i++) { cout << "\t"; }
}

#endif

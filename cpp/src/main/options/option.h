#include <iostream>
#include "..\revlib\repeat.h"

#ifndef OPTION_H
#define OPTION_H

using namespace std;

void addOption(int num, string name, bool newline, bool tabs, int _tabsln) {
	if (tabs) { tab_repeat(_tabsln); }
	if (!name.empty()) { cout << "[" << num << "] " << name; } else { cout << "[N/A] Option"; }
	if (newline) { cout << "\n"; } 
}

void addCategory(string name, bool newline, bool tabs, int _tabsln) {
	if (tabs) { tab_repeat(_tabsln); }
	if (!name.empty()) { cout << name; } else { cout << "Category Name"; }
	if (newline) { cout << "\n"; }
}

#endif

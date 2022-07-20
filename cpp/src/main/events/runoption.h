#include <iostream>
#include "..\revlib\errorparse.h"
#include "..\includedoptions\testoption\Test.h"

#ifndef RUNOPTION_H
#define RUNOPTION_H

using namespace std;

void runOption(int a)
{
	switch(a)
	{
		case 1: test();
		default: throwInvalidError("Option");
	}
}

#endif

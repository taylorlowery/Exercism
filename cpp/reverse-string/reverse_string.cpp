#include "reverse_string.h"
#include <string>
#include <iostream>
#include <algorithm>

using namespace std;


namespace reverse_string {
    
    string reverse_string(string input) {
        reverse(input.begin(), input.end());
        return input;
    }

    // The hard way:
    /*
    string reverse_string(string input){
        int length = input.length() - 1;
        for (int i = 0; i < length / 2; i++){
            char temp = input[length - i];
            input[length - i] = input[i];
            input[i] = temp;
        }

        cout << input << endl;
        return input;
    }
    */
}  // namespace reverse_string

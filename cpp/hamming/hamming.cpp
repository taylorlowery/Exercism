#include "hamming.h"

#include <string>
using namespace std;

namespace hamming
{
    int compute(string strand1, string strand2)
    {
        if (strand1.length() != strand2.length()){
            throw domain_error("The strands must be of the same length.");
        }
        int hamming_distance = 0;
        for (int i = 0; i < strand1.length(); i++)
        {
            if (strand1[i] != strand2[i])
            {
                hamming_distance++;
            }
        }
        return hamming_distance;
    }
} // namespace hamming

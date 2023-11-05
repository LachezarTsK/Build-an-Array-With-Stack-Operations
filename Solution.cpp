
#include <vector>
using namespace std;

class Solution {
    
    static const int MIN_POSSIBLE_VALUE = 1;

public:
    vector<string> buildArray(const vector<int>& target, int maxPossibleValue) const {
        
        int indexTarget = 0;
        int value = MIN_POSSIBLE_VALUE;
        vector<string> stackOperationsToBuildTarget;

        while (value <= target[target.size() - 1]) {
            stackOperationsToBuildTarget.emplace_back("Push");
            if (value != target[indexTarget]) {
                stackOperationsToBuildTarget.emplace_back("Pop");
            } else {
                ++indexTarget;
            }
            ++value;
        }
        return stackOperationsToBuildTarget;
    }
};

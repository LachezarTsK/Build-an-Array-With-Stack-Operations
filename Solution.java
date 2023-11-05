
import java.util.ArrayList;
import java.util.List;

public class Solution {

    private static final int MIN_POSSIBLE_VALUE = 1;

    public List<String> buildArray(int[] target, int maxPossibleValue) {

        int indexTarget = 0;
        int value = MIN_POSSIBLE_VALUE;
        List<String> stackOperationsToBuildTarget = new ArrayList<>();

        while (value <= target[target.length - 1]) {
            stackOperationsToBuildTarget.add("Push");
            if (value != target[indexTarget]) {
                stackOperationsToBuildTarget.add("Pop");
            } else {
                ++indexTarget;
            }
            ++value;
        }
        return stackOperationsToBuildTarget;
    }
}

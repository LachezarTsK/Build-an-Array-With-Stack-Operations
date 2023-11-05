
/**
 * @param {number[]} target
 * @param {number} maxPossibleValue
 * @return {string[]}
 */
var buildArray = function (target, maxPossibleValue) {

    const MIN_POSSIBLE_VALUE = 1;
    const stackOperationsToBuildTarget = new Array();

    let indexTarget = 0;
    let value = MIN_POSSIBLE_VALUE;

    while (value <= target[target.length - 1]) {
        stackOperationsToBuildTarget.push("Push");
        if (value !== target[indexTarget]) {
            stackOperationsToBuildTarget.push("Pop");
        } else {
            ++indexTarget;
        }
        ++value;
    }
    return stackOperationsToBuildTarget;
};

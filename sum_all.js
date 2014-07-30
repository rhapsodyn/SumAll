l = [1, 2, 3, [1, [2, 3]]];
var LEN = 6;

function sumAll (list) {
	if (list.length == 0) {
		return 0;
	} else if (list[0].length > 0) {
		return sumAll(list[0]) + sumAll(list.slice(1, LEN));
	} else {
		return list[0] + sumAll(list.slice(1, LEN));
	}
}

console.log(sumAll(l));
l = [1, 2, 3, [1, [2, 3]]]

def sum_all list
	if list.length == 0
		0
	elsif list[0].respond_to? 'each'
		sum_all(list[0]) + sum_all(list[1..-1])	
	else	
		list[0] + sum_all(list[1..-1])
	end
end

puts sum_all l
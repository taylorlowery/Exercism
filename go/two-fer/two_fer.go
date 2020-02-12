package twofer

// ShareWith returns "one for X, one for me"
func ShareWith(name string) string {
	if len(name) == 0 {
		name = "you"
	}

	return "One for " + name + ", one for me."
}

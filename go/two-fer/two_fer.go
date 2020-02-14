// Package twofer provides a method for checking a name
// and returning a message based on that name
package twofer

// ShareWith returns "one for X, one for me"
func ShareWith(name string) string {
	if name == "" {
		name = "you"
	}

	return "One for " + name + ", one for me."
}

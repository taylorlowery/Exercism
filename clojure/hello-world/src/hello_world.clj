(ns hello-world)

(defn hello  ;; <- arglist goes here
  ([name] (str "Hello, " name "!"))
  ([]
    (hello "World"))
)

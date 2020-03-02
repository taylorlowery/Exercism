(ns armstrong-numbers
  (:require [clojure.string :as str]
            [clojure.math.numeric-tower :as math]))

(defn num-to-digits [num]
  (into [] (map #(Integer/parseInt %) (str/split (str num) #""))))

(defn armstrong? [num]
  (let [digits (num-to-digits num)
        exponent (count digits)]
    (= num (reduce + (map #(math/expt % exponent) digits)))))

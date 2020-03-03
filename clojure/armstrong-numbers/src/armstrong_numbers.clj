(ns armstrong-numbers
  (:require [clojure.string :as str]
            [clojure.math.numeric-tower :as math]))

(defn num-to-digits [num]
      (->> num
           (str)
           (map #(Character/digit % 10))
           (into [])))

(defn armstrong? [num]
      (let [digits (num-to-digits num)
            exponent (count digits)]
           (= num
              (->> digits
                   (map #(math/expt % exponent))
                   (reduce +)))))

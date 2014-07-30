(DEFVAR *L* `(1 2 3 (1 (2 3))))

(DEFUN SUM-ALL (LIST)
       (COND ((ENDP LIST) 0)
             ((NUMBERP (FIRST LIST))
              		(+ (FIRST LIST) (SUM-ALL (REST LIST))))
             (T (+ (SUM-ALL (FIRST LIST)) (SUM-ALL (REST LIST))))))

(SUM-ALL *L*)
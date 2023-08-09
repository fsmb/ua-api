# Exam

Exam. 

| Name | Type | Required | Description |
| - | - | - | - |
| examType | string (len: 100) | Yes | Type of exam. |
| stateBoardDetail | [ExamStateBoard](exam-state-board.md) | No | State board description. |
| examDate | string (date) | Yes | Exam date. |
| numberOfAttempts | integer | Yes | Number of attempts. |
| passFail | string (len: 100) | Yes | Pass/fail status (e.g. `Pass`, `Fail`, `Unknown`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| stateBoard | | | **Deprecated**. Use `stateBoardDetail`. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

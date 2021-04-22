//
//  MMTree.h
//  Test_Tree
//
//  Created by Morris_ on 2021/4/20.
//

#import <Foundation/Foundation.h>
#import "MMNode.h"

NS_ASSUME_NONNULL_BEGIN

// 二叉树
@interface MMTree : NSObject

// 首节点
@property (nonatomic, strong, nullable) MMNode *rootNode;

// 添加"左孩子"(左节点)
- (BOOL)addLeftNode:(nullable MMNode *)left inNode:(MMNode *)node;
// 添加”右孩子“（右节点）
- (BOOL)addRightNode:(nullable MMNode *)right inNode:(MMNode *)node;

// 求节点数
- (NSInteger)countNodes;

// 叶子数
- (NSInteger)countLeaves;

@end

NS_ASSUME_NONNULL_END

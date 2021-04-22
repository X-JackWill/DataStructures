//
//  MMTree.m
//  Test_Tree
//
//  Created by Morris_ on 2021/4/20.
//

#import "MMTree.h"

@implementation MMTree

- (BOOL)addLeftNode:(nullable MMNode *)left inNode:(MMNode *)node {
    if (node) {
        node.left = nil;
        node.left = left;
        return YES;
    }
    return NO;
}
- (BOOL)addRightNode:(nullable MMNode *)right inNode:(MMNode *)node {
    if (node) {
        node.right = nil;
        node.right = right;
        return YES;
    }
    return NO;
}

- (NSInteger)countNodes {
    if (self.rootNode) {
        return [self.rootNode countNodes];
    }
    return 0;
}

- (NSInteger)countLeaves {
    if (self.rootNode) {
        return [self.rootNode countLeaves];
    }
    return 0;
}

@end
